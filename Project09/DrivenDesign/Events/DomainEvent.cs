using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivenDesign.Events
{
    public class DomainEvent
    {
        public DateTime OccurredOn { get; }

        public DomainEvent()
        {
            OccurredOn = DateTime.UtcNow;
        }
    }
}