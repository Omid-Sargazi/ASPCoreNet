using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class OrderItem
    {
        public Guid Id {get; private set;}
        public string ProductName {get; private set;}
        public int Quantity {get; private set;}
        public Money Price {get; private set;}

        public OrderItem(Guid id, string productName, int quantity, Money price)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
             Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }

        public Money GetTotalPrice()
        {
            return new Money(Price.Amount * Quantity, Price.Currency);
        }
    }
}