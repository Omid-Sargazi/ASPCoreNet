using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomainEventsForms02.Entities
{
    public class OrderPlaced
    {
    public int OrderId { get; }
    public string CustomerName { get; }

    public OrderPlaced(int orderId, string customerName)
    {
        OrderId = orderId;
        CustomerName = customerName;
    }
    
    }
}