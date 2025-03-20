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
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}