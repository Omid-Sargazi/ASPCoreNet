using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Events;

namespace Domain.Handlers
{
    public class OrderPlacedEventHandler
    {
        public void Handle(OrderPlacedEvent orderPlacedEvent)
        {
           Console.WriteLine($"Order placed with ID: {orderPlacedEvent.OrderId}, for Customer: {orderPlacedEvent.CustomerId}");
        }
    }
}