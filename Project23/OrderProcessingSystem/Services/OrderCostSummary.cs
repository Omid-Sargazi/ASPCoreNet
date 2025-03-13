using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services
{
    public class OrderCostSummary
    {
        public decimal SubTotal {get;set;}
        public decimal Tax {get; set;}
        public decimal ShippingCost {get; set;}
        public decimal TotalAmount {get;set;}
    }
}