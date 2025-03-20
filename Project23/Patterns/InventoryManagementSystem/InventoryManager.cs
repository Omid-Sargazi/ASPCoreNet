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

        public void UpdateStock(string productId, int quantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if(product !=null)
                product.Stock +=quantity;
        }

        public ProductOfSystem SearchProduct(string keyword)
        {
            return _products.FirstOrDefault(p => p.Id == keyword || p.Name == keyword);
        }

        public void RemoveProduct(string productId)
        {
            var product = _products.FirstOrDefault(p => p.Id ==productId);
            if(product !=null)
                _products.Remove(product);
        }

         public void DisplayProducts()
    {
        foreach (var product in _products)
        {
            Console.WriteLine(product);
        }
    }
    }
}