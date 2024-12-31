using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternExample.models;

namespace RepositoryPatternExample.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task AddProductAsync(string Name, string Price);
        Task UpdateProductAsync(int id, string name, decimal price);
        Task DeleteProductAsync(int id);
    }
}