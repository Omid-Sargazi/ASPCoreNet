using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class Order : IPrototype<Order>
    {
        public List<string> Items {get; set;}
        public Order CLone()
        {
            var clone =  (Order)this.MemberwiseClone();
            clone.Items = new List<string>(this.Items);
            return clone;
        }
    }
}