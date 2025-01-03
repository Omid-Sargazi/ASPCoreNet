using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWareMicrosoft.MiddleWares
{
    public class IPLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        public IPLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress?.ToString();
            Console.WriteLine($"Request from IP: {ipAddress}");
            await _next(context);
        }
    }
}