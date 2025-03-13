using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderProcessingSystem.Data;
using OrderProcessingSystem.Interfacses;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Implements
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public OrderRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> CreateAsync(Order order)
        {
            order.Id = Guid.NewGuid().ToString();
            order.OrderDate = DateTime.UtcNow;
            order.Status = OrderStatus.Created;

            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
            return order.Id;
        }

        public async Task<List<Order>> GetByCustomerIdAsync(int customerId)
        {
            return await _dbContext.Orders
            .Include(o => o.Items)
            .Where(o => o.CustomerId == customerId)
            .ToListAsync();
        }

        public async Task<Order> GetByIdAsync(string id)
        {
           return await _dbContext.Orders
           .Include(o => o.Items)
           .FirstOrDefaultAsync(o => o.Id==id);
        }

        public async Task UpdateAsync(Order order)
        {
            _dbContext.Orders.Update(order);
            await _dbContext.SaveChangesAsync();
        }
    }
}