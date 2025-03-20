using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class Orders : IPrototype<Orders>
    {
        public List<OrderItem> Items {get; set;}
        public Orders CLone()
        {
            var clone = (Orders)this.MemberwiseClone();
            clone.Items = this.Items.Select(i => i.CLone()).ToList();
            return clone;
        }
    }
}