using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Events
{
    public abstract class DomainEvent
    {
        public DateTime OccurredOn {get;} = DateTime.UtcNow;
    }
}