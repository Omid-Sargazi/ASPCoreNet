using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Interfacses
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByIdAsync(int id);
        Task<Customer> GetByEmailAsync(string email);
        Task UpdateAsync(Customer customer);
    }
}