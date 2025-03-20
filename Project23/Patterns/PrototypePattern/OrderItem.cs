using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class OrderItem : IPrototype<OrderItem>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public OrderItem CLone()
        {
            return (OrderItem)this.MemberwiseClone();
        }
    }
}