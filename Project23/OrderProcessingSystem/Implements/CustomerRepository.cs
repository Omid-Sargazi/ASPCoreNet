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
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ECommerceDbContext _dbContext;

        public CustomerRepository(ECommerceDbContext dbContext)
        {
            _dbContext = dbContext;   
        }
        public async Task<Customer> GetByEmailAsync(string email)
        {
            return await _dbContext.Customers
            .Include(c => c.ShippingAddress)
            .Include(c => c.BillingAddress)
            .FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            return await _dbContext.Customers
            .Include(c => c.ShippingAddress)
            .Include(c => c.BillingAddress)
            .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task UpdateAsync(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            await _dbContext.SaveChangesAsync();
        }
    }
}