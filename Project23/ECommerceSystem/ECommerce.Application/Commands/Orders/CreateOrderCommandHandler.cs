using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Application.DTOs;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;
using MediatR;

namespace ECommerce.Application.Commands.Orders
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderDto>
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IRepository<Order> orderRepository, IMapper mapper)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }
        public async Task<OrderDto> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
           var order = new Order
           {
                CustomerId = request.CustomerId,
                OrderItems = request.Items.Select(x => new OrderItem
                {
                    ProductId = x.ProductId,
                    Quantity = x.Quantity
                }).ToList()
           };

           await _orderRepository.AddAsync(order);
           return _mapper.Map<OrderDto>(order);
        }
    }
}