using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MiddlewareExample02.Configurations;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;


namespace MiddlewareExample02.Middlewares
{
    public class LoggingMiddleware02
    {
        private readonly RequestDelegate _next;
        private readonly LoggingOptions _options;

        public LoggingMiddleware02(RequestDelegate next, IOptions<LoggingOptions> options)
        {
            _next = next;
            _options = options.Value;
        }

            public async Task Invoke(HttpContext context)
        {
            if (_options.LogRequests)
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
            await _next(context);

            if(_options.LogResponses)
                Console.WriteLine($"Response: {context.Response.StatusCode}");
        }
    }
}