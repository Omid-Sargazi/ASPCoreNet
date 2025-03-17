using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Application.DTOs;
using MediatR;

namespace ECommerce.Application.Commands.Customers
{
    public class CreateCustomerCommand:IRequest<CustomerDto>
    {
        public string Name {get;set;}
        public string Email {get;set;}
    }
}