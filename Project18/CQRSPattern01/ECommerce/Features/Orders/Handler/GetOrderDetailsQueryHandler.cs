using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Entities;
using ECommerce.Features.Orders.Queries;
using ECommerce.Repositories;
using MediatR;

namespace ECommerce.Features.Orders.Handler
{
    public class GetOrderDetailsQueryHandler:IRequestHandler<GetOrderDetailsQuery,Order>
    {
        private readonly IOrderRepository _orderRepository;   
        
        public GetOrderDetailsQueryHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;   
        }

        public async Task<Order> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _orderRepository.GetOrderByIdAsync(request.OrderId);
        }
    }
}