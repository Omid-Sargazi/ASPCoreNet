using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderManagement.Models;
using OrderManagement.Repositories;
using OrderManagement.Services;

namespace OrderManagement.Implements
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }
        public async Task AddOrderAsync(string customerName, DateTime orderDate, decimal TotalAmount)
        {
            var order = new Order{
                CustomerName = customerName,
                OrderDate = orderDate,
               
            };
            await _repository.AddAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<Order?> GetOrderByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
           return await _repository.GetAllAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersWithProductsAsync()
        {
            return await _repository.GetOrdersWithProductsAsync();
        }

        public async Task UpdateOrderAsync(int id, string customerName, DateTime orderDate, decimal TotalAmount)
        {
            var order = await _repository.GetByIdAsync(id);
            if(order !=null)
            {
                order.OrderDate = orderDate;
                order.CustomerName = customerName;
                
                await _repository.UpdateAsync(order);
            }
        }
    }
}