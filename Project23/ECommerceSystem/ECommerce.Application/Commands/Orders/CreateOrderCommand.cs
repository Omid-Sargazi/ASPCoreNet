using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Application.DTOs;
using MediatR;

namespace ECommerce.Application.Commands.Orders
{
    public class CreateOrderCommand:IRequest<OrderDto>
    {
        public int CustomerId {get; set;}
        public List<OrderItemDto> Items {get; set;} = new();
    }
}