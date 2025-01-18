using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCommandResponse.Data
{
    public class Metadata
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CorrelationId { get; set; }
        public string Version { get; set; }

        public Metadata()
        {
            CreatedAt = DateTime.UtcNow;
            CreatedBy = "System";
            CorrelationId = Guid.NewGuid().ToString();
            Version="1.0";
        }
    }
}