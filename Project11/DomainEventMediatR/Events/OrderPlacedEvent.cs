using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace DomainEventMediatR.Events
{
    public class OrderPlacedEvent:INotification
    {
        public Guid OrderId {get; set;}
        public Guid CustomerId {get; set;}
        public DateTime OccurredOn {get; set;}

        public OrderPlacedEvent(Guid orderId, Guid customerId)
        {
            OrderId = orderId;
            CustomerId = customerId;
            OccurredOn = DateTime.UtcNow;
        }
    }
}