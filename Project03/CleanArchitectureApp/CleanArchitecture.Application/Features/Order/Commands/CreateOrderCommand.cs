using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CleanArchitecture.Application.Features.Order.Commands
{
    public class CreateOrderCommand:IRequest<Guid>
    {
        public string CustomerName {get;set;}
        public decimal TotalAmount {get;set;}
    }
}