using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Services.ServiceInterfaces
{
    public interface IShippingCalculator
    {
        Task<decimal> CalculateShippingAsync(Order order, Address shippingAddress);
    }
}