using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.InventoryManagementSystem
{
    public class InventoryManager
    {
        public List<ProductOfSystem> _products = new List<ProductOfSystem>();

        public void AddProduct(ProductOfSystem productOfSystem)
        {
            _products.Add(productOfSystem);
        }
    }
}