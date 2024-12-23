using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs
{
    public class OrderDto
    {
        public Guid Id {get;set;}
        public string CustomerName {get;set;}
        public decimal TotalAmount {get;set;}
    }
}