using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Services
{
    public class OrderRequest
    {
        public int CustomerId {get; set;}
        public List<OrderItemRequest> Items {get; set;}
        public PaymentMethod PaymentMethod {get; set;}
    }
}