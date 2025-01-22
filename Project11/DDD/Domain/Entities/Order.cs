using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id {get; private set;}
        public string CustomerName {get; private set;}
        public Address ShippingAddress {get; private set;}
        public List<Product> Products {get; private set;}

        public Order(Guid id, string customerName, Address shippingAddress)
        {
            if(string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentException("Customer name cannot be empty.");
            
            Id= id;
            CustomerName = customerName;
            ShippingAddress = shippingAddress;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        
    }
}