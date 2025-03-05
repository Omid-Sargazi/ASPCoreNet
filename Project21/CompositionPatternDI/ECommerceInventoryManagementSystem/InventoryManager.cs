using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public class InventoryManager : IInventoryManager
    {
        private readonly List<IProduct> _products = new();
        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public bool CheckAvailability(int productId)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            return product?.CheckAvailability()??false;
        }

        public void ListProducts()
        {
            foreach(var product in _products)
            {
                Console.WriteLine($"{product.Name}: ${product.CalculatePrice()} - Available: {product.CheckAvailability()}");
            }
        }

        public void UpdateProductQuantity(int productId, int quantity)
        {
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if(product != null)
                product.Quantity =quantity;
        }
    }
}