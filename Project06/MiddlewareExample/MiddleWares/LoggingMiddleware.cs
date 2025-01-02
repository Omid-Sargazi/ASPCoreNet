using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample.MiddleWares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"Logging Middleware - Before Rrquest: {context.Request.Method} {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"Logging Middleware - After => {context.Response.StatusCode}");
        }
    }
}