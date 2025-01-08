using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExamples02.Middlewares
{
    public class RequestValidationMiddleware
    {
        private readonly RequestDelegate _next;
        
        public RequestValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.ContentType=="application/json")
            {
                var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
                if(string.IsNullOrWhiteSpace(body))
                {
                    context.Response.StatusCode=400;
                    await context.Response.WriteAsync("Invalid request body");
                    return;
                }
                context.Request.Body = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(body));
            }

            await _next(context);
        }
    }
}