using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Events;

namespace BookstoreManagementSystem.TestUnit.OrderPlacedEventTests
{
    public class OrderPlacedEventTests
    {
        [Fact]
        public void Should_Create_Valid_OrderPlacedEvent()
        {
            var orderId = 1;
            var placedAt = DateTime.UtcNow;

            var orderPlacedEvent = new OrderPlacedEvent(orderId, placedAt);

            Assert.Equal(orderId, orderPlacedEvent.OrderId);
            Assert.Equal(placedAt, orderPlacedEvent.PlacedAt);
            
        }
    }
}