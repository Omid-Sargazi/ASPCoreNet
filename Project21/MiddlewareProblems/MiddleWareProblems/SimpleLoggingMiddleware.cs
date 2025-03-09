using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareProblems.MiddleWareProblems
{
    public class SimpleLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<SimpleLoggingMiddleware> _logger;

        public SimpleLoggingMiddleware(RequestDelegate next, ILogger<SimpleLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;   
        }

        public async Task InvokeAsync(HttpContext context)
        {
            _logger.LogInformation($"Request Received:{context.Request.Path}");
            await _next(context);

            _logger.LogInformation($"Response Complete with status{context.Response.StatusCode}");
        }

        
    }

   }