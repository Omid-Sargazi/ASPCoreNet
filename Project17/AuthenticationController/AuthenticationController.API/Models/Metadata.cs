using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationController.API.Models
{
    public class Metadata
    {
        public string CorrelationId {get; set;}
        public string Source {get; set;}
        public DateTime Timestamp {get; set;} = DateTime.UtcNow;
    }
}