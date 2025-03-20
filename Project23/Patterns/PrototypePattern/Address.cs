using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class Address : ICloneable
    {
        public string City {get; set;}
        public string Street {get; set;}
        public object Clone()
        {
           return this.MemberwiseClone();
        }
    }
}