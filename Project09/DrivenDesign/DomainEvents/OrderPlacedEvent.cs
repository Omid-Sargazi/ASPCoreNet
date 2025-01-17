using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrivenDesign.DomainEvents
{
    public class OrderPlacedEvent
    {
    public int OrderId { get; private set; }
    public DateTime OrderDate { get; private set; }

    public OrderPlacedEvent(int orderId, DateTime orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }
    }
}