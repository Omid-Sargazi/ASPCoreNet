using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTestDemo.Data;

namespace IntegrationTestDemo.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
    }
}