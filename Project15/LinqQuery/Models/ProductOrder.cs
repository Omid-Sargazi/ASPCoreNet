using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQuery.Models
{
    public class ProductOrder
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 101, ProductId = 1, Quantity = 2, OrderDate = new DateTime(2023, 10, 1) },
                new Order { OrderId = 2, CustomerId = 102, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2023, 10, 2) },
                new Order { OrderId = 3, CustomerId = 103, ProductId = 3, Quantity = 3, OrderDate = new DateTime(2023, 10, 3) },
                new Order { OrderId = 4, CustomerId = 101, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2023, 10, 4) }
            };

            var customers = new List<Customer>
            {
                new Customer { CustomerId = 101, CustomerName = "Alice", Email = "alice@example.com" },
                new Customer { CustomerId = 102, CustomerName = "Bob", Email = "bob@example.com" },
                new Customer { CustomerId = 103, CustomerName = "Charlie", Email = "charlie@example.com" }
            };

            var products = new List<ProductOrder>
            {
                new ProductOrder { ProductId = 1, ProductName = "Laptop", Price = 1200.00m },
                new ProductOrder { ProductId = 2, ProductName = "Smartphone", Price = 800.00m },
                new ProductOrder { ProductId = 3, ProductName = "Tablet", Price = 500.00m }
            };
    }
}