using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Entities;
using ECommerce.Features.Orders.Commands;
using ECommerce.Repositories;
using MediatR;

namespace ECommerce.Features.Orders.Handler
{
    public class PlaceOrderCommandHandler : IRequestHandler<PlaceOrderCommand, Guid>
    {
        private IOrderRepository _orderRepository;

        public PlaceOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;   
        }
        public async Task<Guid> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                CustomerName = request.CustomerName,
                ProductName = request.ProductName,
                Quantity = request.Quantity,
                TotalPrice = request.TotalPrice
            };

            var createdOrder = await _orderRepository.AddOrderAsync(order);
            return createdOrder.Id;
        }
    }
}