using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Events
{
    public class OrderCancelledEvent
    {
        public int OrderId {get;}
        public DateTime CancelledAt{get;}

        public OrderCancelledEvent(int orderId, DateTime cancelledAt)
        {
            OrderId = orderId;
            CancelledAt = cancelledAt;
        }
    }
}