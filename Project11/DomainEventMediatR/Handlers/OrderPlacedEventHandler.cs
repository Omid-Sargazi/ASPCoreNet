using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainEventMediatR.Events;
using MediatR;

namespace DomainEventMediatR.Handlers
{
    public class OrderPlacedEventHandler : INotificationHandler<OrderPlacedEvent>
    {
        public async Task Handle(OrderPlacedEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Order placed with ID: {notification.OrderId} for Customer: {notification.CustomerId}");
            await Task.CompletedTask;
        }
    }
}