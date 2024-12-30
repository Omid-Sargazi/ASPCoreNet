using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternDemo.models;

namespace RepositoryPatternDemo.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task AddProductAsync(string name, decimal price);
        Task UpdateProductAsync(int id, string name, decimal price);
        Task DeleteProductAsync(int id);
    }
}