using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiddlewareExample.MiddleWares;

namespace MiddlewareExample.MainClasses
{
    public static class RequestTimingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestTiming(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestTimingMiddleware>();
        }
    }
}