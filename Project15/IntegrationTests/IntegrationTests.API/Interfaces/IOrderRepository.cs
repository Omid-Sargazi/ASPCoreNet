using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.API.Models;

namespace IntegrationTests.API.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> GetOrderAsync(int orderId);
        Task SaveOrderAsync(Order order);
    }
}