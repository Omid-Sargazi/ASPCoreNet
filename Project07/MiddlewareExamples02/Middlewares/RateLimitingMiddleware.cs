using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples02.Middlewares
{
    public class RateLimitingMiddleware
    {
        private static readonly Dictionary<string, int> Requests = new();
        private readonly RequestDelegate _next;

        public RateLimitingMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            var ipAddress = context.Connection.RemoteIpAddress?.ToString();
            if(!Requests.ContainsKey(ipAddress)) Requests[ipAddress] = 0;

            if(Requests[ipAddress] >= 5)
            {
                context.Response.StatusCode = 429;
                 context.Response.WriteAsync("Too many requests");
                return;
            }

            Requests[ipAddress]++;
            await _next(context);
            Requests[ipAddress]--; // Decrease count after request
        }
    }
}