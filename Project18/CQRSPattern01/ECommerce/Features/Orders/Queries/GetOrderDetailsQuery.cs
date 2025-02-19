using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Entities;
using MediatR;

namespace ECommerce.Features.Orders.Queries
{
    public class GetOrderDetailsQuery:IRequest<Order>
    {
        public Guid OrderId {get; set;}   
    }
}