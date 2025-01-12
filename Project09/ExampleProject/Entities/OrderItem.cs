using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Entities
{
    public class OrderItem
    {
        public Guid ProductId {get; protected set;}
        public int Quantity {get; protected set;}
        public decimal Price {get; protected set;}

        public OrderItem(Guid productId, int quantity, decimal price)
        {
            if(quantity <0)
                throw new ArgumentException("Quantity must be greater than zero.");
            
            if(price <0)
                throw new ArgumentException("Price must be greater than zero.");
            
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
    }
}