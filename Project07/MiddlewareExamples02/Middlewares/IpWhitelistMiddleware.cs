using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples02.Middlewares
{
    public class IpWhitelistMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly List<string> _whitelistedIps;

        public IpWhitelistMiddleware(RequestDelegate next, List<string> whitelistedIps)
        {
            _next = next;
            _whitelistedIps = whitelistedIps;
        }

        public async Task InvokeAsync(HttpContext context)
        {
        var ipAddress = context.Connection.RemoteIpAddress?.ToString();
        if (!_whitelistedIps.Contains(ipAddress))
        {
            context.Response.StatusCode = 403;
            await context.Response.WriteAsync("Forbidden");
            return;
        }
        await _next(context);
    }

    }
}