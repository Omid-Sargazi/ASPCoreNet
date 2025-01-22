using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Product
    {
        public Guid Id {get; private set;}
        public string Name {get; set;}
        public Money Price {get; set;}

        public Product(Guid id, string name, Money price)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name cannot be empty.");
            
            Id = id;
            Name = name;
            Price = price;
        }

        public void UpdatePrice(Money newPrice)
        {
           if(newPrice.Amount < 0)
            throw new ArgumentException("Price must be greater than zero.");

            Price = newPrice;
        }

        public override bool Equals(Object? obj)
        {
            if(obj is not Product other) return false;
            return Id == other.Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}