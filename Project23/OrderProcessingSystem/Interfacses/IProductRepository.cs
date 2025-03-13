using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Interfacses
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetByIdsAsync(List<int> ids);
        Task UpdateStockAsync(int productId, int quantity);
    }
}