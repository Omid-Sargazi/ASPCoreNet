using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.Exceptions
{
    public class Product
    {
        public string Name { get; private set; }
        public string SKU { get; private set; }
        public decimal Price { get; private set; }
        public int CategoryId { get; private set; }
        public int CurrentStock { get; private set; }
        public int MinimumStockLevel { get; private set; } 


        private Product(){}//For EF Core

        public Product(string name, string sku, decimal price, int categoryId, int minimumStockLevel)
        {
            Name = name;
            SKU = sku;
            Price = price;
            CategoryId = categoryId;
            CurrentStock = 0;
            MinimumStockLevel = minimumStockLevel;
        }

        private void Validate(string name, string sku, decimal price, int minimumStockLevel)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name is required");
            
            if(string.IsNullOrWhiteSpace(sku))
                throw new ArgumentException("SKU cannot be empty.");
            if(price < 0)
                throw new ArgumentException("Price cannot be less than zero.");
        }
        
        public void UpdatePrice(decimal newPrice)
        {
            if(newPrice < 0)
                {
                    throw new ArgumentException("Price cannot be less than zero.");
                }
            Price = newPrice;
        }

        public void UpdateStock(int quantity)
        {
            CurrentStock += quantity;
            if(CurrentStock< 0)
                throw new ArgumentException("Stock cannot be negative.");
        }

    }
}