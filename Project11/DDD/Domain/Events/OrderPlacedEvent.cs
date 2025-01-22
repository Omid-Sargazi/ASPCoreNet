using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Events
{
    public class OrderPlacedEvent : IDomainEvent
    {
        public DateTime OccurredOn {get; private set;}
        public Guid OrderId {get;}
        public Guid CustomerId {get;}

        public OrderPlacedEvent(Guid orderId, Guid customerId)
        {
            OrderId = orderId;
            CustomerId = customerId;
            OccurredOn = DateTime.UtcNow;
        }
    }
}