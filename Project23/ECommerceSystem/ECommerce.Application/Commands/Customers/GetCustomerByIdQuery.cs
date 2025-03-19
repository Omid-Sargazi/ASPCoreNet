using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Application.DTOs;
using MediatR;

namespace ECommerce.Application.Commands.Customers
{
    public class GetCustomerByIdQuery:IRequest<CustomerDto>
    {
        public int Id {get; set;}
    }
}