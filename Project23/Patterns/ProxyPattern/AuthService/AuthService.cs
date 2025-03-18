using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.AuthService
{
    public class AuthService : IAuthService
    {
        public bool Authenticate(string username, string password)
        {
             // شبیه‌سازی یک عملیات پرهزینه (مثلاً درخواست به دیتابیس)
        Console.WriteLine($"Authenticating user {username}...");
        // شبیه‌سازی بررسی اعتبار کاربر
        return username == "admin" && password == "password";
        }
    }
}