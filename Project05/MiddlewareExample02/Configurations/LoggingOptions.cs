using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareExample02.Configurations
{
    public class LoggingOptions
    {
        public bool LogRequests {get;set;}
        public bool LogResponses {get;set;}
    }
}