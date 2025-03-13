using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Services.ServiceInterfaces
{
    public interface IOrderFulfillmentService
    {
        Task<OrderResult> FulfillOrderAsync(Order order, Customer customer, OrderCostSummary orderCostSummary);
    }
}