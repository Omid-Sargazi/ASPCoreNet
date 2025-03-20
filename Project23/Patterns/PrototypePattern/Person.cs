using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class Person : ICloneable
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public Address Address {get; set;}
        public object Clone()
        {
            var clone = (Person)this.MemberwiseClone();
            clone.Address = (Address)this.Address.Clone();
            return clone;
        }
    }
}