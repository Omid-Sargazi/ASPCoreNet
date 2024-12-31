using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderManagement.Models;

namespace OrderManagement.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task<Order?> GetOrderByIdAsync(int id);
        Task AddOrderAsync(string customerName, DateTime orderDate,decimal TotalAmount);
        Task UpdateOrderAsync(int id, string customerName, DateTime orderDate, decimal TotalAmount);
        Task DeleteOrderAsync(int id);
        Task<IEnumerable<Order>> GetOrdersWithProductsAsync();

    }
}