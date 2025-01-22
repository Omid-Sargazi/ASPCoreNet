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
        public Guid CustomerId  {get; private set;}
        public Address ShippingAddress {get; private set;}
        public List<OrderItem> _items  = new();
        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();

        public Order(Guid id, Guid customerId, Address shippingAddress,List<OrderItem> items)
        {
            if (items == null || items.Count == 0)
                throw new InvalidOperationException("An order must contain at least one item.");
            

            Id= id;
            CustomerId = customerId;
            ShippingAddress = shippingAddress;
            _items.AddRange(items);
        }

        public Money GetTotalOrderPrice()
        {
            var total = _items.Sum(item => item.GetTotalPrice().Amount);
            return new Money(total, _items.First().Price.Currency);
        }
        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

         public void RemoveItem(Guid itemId)
        {
            var item = _items.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                _items.Remove(item);
            }

        
    }
      
    }
}