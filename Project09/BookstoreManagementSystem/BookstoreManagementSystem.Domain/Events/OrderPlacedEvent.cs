using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Events
{
    public class OrderPlacedEvent
    {
        public int OrderId {get;}
        public DateTime PlacedAt{get;}
        public OrderPlacedEvent(int orderId, DateTime placeAt)
        {
            OrderId = orderId;
            PlacedAt = placeAt;
        }
    }
}