using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtensionMethods02.MiddleWares;
using Microsoft.AspNetCore.Builder;

namespace ExtensionMethods02.Main
{
    public static class RequestLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLoggingMiddleware>();
        }
    }
}