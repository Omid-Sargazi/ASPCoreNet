using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiddlewareExample02.Repositories;

namespace MiddlewareExample02.Middlewares
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;

        public ApiKeyMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext context, IApiKeyValidator validator)
        {
            if(!context.Request.Headers.TryGetValue("X-Api-Key", out var extractedApiKey) ||validator.IsValid(extractedApiKey))
            {
                context.Response.StatusCode=401;
                await context.Response.WriteAsync("invalid Api Key");
                return;
            }

            await _next(context);
        }
    }
}