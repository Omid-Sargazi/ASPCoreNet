using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Services.ServiceInterfaces
{
    public interface ITaxCalculator
    {
        Task<decimal> CalculateTaxAsync(Order order, Address shippingAddress);
    }
}