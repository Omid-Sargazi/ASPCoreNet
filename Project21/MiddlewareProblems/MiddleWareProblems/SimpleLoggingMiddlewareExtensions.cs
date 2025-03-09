using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareProblems.MiddleWareProblems
{
    public static class SimpleLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder useSimpleLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SimpleLoggingMiddleware>();
        } 
    }
}