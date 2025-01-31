using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern.ApiServices
{
    public class RateLimitingProxy:IApiService
    {
        private readonly RealApiService _realApiService;
        private readonly Dictionary<string, Queue<DateTime>> _requestLogs = new();
        private readonly int _maxRequest;
        private readonly TimeSpan _timeWindow;

        public RateLimitingProxy(int maxRequest, TimeSpan timeWindow)
        {
            _realApiService = new RealApiService();
            _maxRequest = maxRequest;
            _timeWindow = timeWindow;

        }

        public string GetData()
        {
            var clientIp = GetClientIpAddress();
            if(!_requestLogs.ContainsKey(clientIp))
            {
                _requestLogs[clientIp] = new Queue<DateTime>();
            }

            var now = DateTime.UtcNow;

            while(_requestLogs[clientIp].Count > 0 && now - _requestLogs[clientIp].Peek()>_timeWindow)
            {
                _requestLogs[clientIp].Dequeue();
            }
            if(_requestLogs[clientIp].Count >= _maxRequest)
            {
                throw new InvalidOperationException("Rate limit exceeded. Please try again later.");
            }

            _requestLogs[clientIp].Enqueue(now);
            return _realApiService.GetData();
        }

        private string GetClientIpAddress()
        {
            return "192.168.1.1";
        }
    }
}