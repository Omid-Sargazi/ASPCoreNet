using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternDemo.Interfaces;
using RepositoryPatternDemo.models;

namespace RepositoryPatternDemo.Implementation
{
    public class ProductRepository : IProductRepository
    {
        public Task AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}