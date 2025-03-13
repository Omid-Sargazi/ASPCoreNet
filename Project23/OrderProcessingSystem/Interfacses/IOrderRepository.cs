using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Interfacses
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(string id);
        Task<List<Order>> GetByCustomerIdAsync(int customerId);
        Task<string> CreateAsync(Order order);
        Task UpdateAsync(Order order);
    }
}