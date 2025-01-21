using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Category
    {
        public Guid Id {get;set;}
        public string Name {get; set;}
        public List<Product> Products {get; private set;} = new List<Product>();

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void AddProduct(Product product){
            if(product ==null)
                throw new ArgumentNullException(nameof(product));
            Products.Add(product);
        }
    }
}