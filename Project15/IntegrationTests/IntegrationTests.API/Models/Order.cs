using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationTests.API.Models
{
    public class Order
    {
        public int Id {get; set;}
        public decimal TotalAmount {get; set;}
        public bool IsPaid {get; set;}
    }
}