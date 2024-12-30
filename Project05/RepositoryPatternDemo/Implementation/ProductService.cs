using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepositoryPatternDemo.Interfaces;
using RepositoryPatternDemo.models;

namespace RepositoryPatternDemo.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public Task AddProductAsync(string name, decimal price)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product?> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(int id, string name, decimal price)
        {
            throw new NotImplementedException();
        }
    }
}