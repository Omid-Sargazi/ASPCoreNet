using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependanyInjection.Repositories;

namespace DependanyInjection.Implements
{
    public class ProductRepository : IProductRepository
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Laptop", "Mouse", "Keyboard" };
        }
    }
}