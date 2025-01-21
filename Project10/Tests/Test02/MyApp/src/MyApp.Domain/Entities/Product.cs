using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Product
    {
        public Guid Id {get;set;}
        public string Name {get;set;}
        public decimal Price {get;set;}
        public Guid CategoryId { get; private set; }
        public Category Category { get; private set; }

        public Product(string name, decimal price, Category category)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price >=0 ? price : throw new ArgumentException("Price cannot be negative.");
            Category = category ?? throw new ArgumentNullException(nameof(category));
            CategoryId = category.Id;
        }
    }
}