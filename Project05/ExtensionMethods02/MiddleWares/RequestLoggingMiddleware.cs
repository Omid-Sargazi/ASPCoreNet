using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ExtensionMethods02.MiddleWares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;           
        }

        public async Task Invoke(HttpContext context)
        {
           var stopWatch = Stopwatch.StartNew();
           Console.WriteLine($"[Request] {context.Request.Method} {context.Request.Path}");
           await _next(context);

            stopWatch.Stop();

            // Log the response details
             Console.WriteLine($"[Response] {context.Response.StatusCode} - {stopwatch.ElapsedMilliseconds}ms");
        }
    }
}