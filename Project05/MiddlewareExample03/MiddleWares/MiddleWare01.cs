using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample03.MiddleWares
{
    public class MiddleWare01 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Started...");
            await next(context);
            await context.Response.WriteAsync("Finished...");
            await context.Response.WriteAsync("Finished 02...");
        }
    }


    public  static class MyMiddleWare
    {
        public static IApplicationBuilder ExtentionMethod(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MiddleWare01>();
        }
    }
}