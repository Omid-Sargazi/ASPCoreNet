using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.AuthService
{
    public class AuthServiceProxy : IAuthService
    {
        private readonly IAuthService _authService;
        private readonly Dictionary<string, bool> _cache = new Dictionary<string, bool>();
        private readonly Dictionary<string, int> _failedAttempts = new Dictionary<string, int>();

        public AuthServiceProxy(IAuthService authService)
        {
            _authService = authService;
        }

        public bool Authenticate(string userName, string Password)
        {
            if(_failedAttempts.ContainsKey(userName) && _failedAttempts[userName]>=3)
            {
                 Console.WriteLine($"User {userName} is blocked due to too many failed attempts.");
            return false;
            }

            var cacheKey = $"{userName}:{Password}";
        if (_cache.ContainsKey(cacheKey))
        {
            Console.WriteLine($"User {userName} authenticated from cache.");
            return _cache[cacheKey];
        }

        var isAuthenticated = _authService.Authenticate(userName, Password);

        // لاگینگ
        Console.WriteLine($"User {userName} authentication result: {isAuthenticated}");

        // ذخیره در کش
        _cache[cacheKey] = isAuthenticated;

        // افزایش تعداد درخواست‌های ناموفق
        if (!isAuthenticated)
        {
            if (_failedAttempts.ContainsKey(userName))
            {
                _failedAttempts[userName]++;
            }
            else
            {
                _failedAttempts[userName] = 1;
            }
        }

        return isAuthenticated;
        }
    }
}