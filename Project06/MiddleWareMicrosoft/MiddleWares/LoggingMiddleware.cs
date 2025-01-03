using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleWareMicrosoft.MiddleWares
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
            Console.WriteLine($"Request Path: {context.Request.Path}");
            await _next(context);
            Console.WriteLine($"Response Status: {context.Response.StatusCode}");
        }
    }
}