using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependanyInjection.Repositories;

namespace DependanyInjection.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    
        public List<string> GetAllProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}