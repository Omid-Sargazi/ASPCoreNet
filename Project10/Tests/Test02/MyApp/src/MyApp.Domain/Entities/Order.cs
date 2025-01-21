using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Order
    {
        public Guid Id {get; set;}
        public DateTime OrderDate {get; private set;}
        public List<Product> Products{get; set;} = new List<Product>();

        public Order()
        {
            Id = Guid.NewGuid();
            OrderDate = DateTime.UtcNow;
        }


        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            Products.Add(product);
        }


        public decimal GetTotalAmount()
        {
            return Products.Sum(p => p.Price);
        }


    }
}