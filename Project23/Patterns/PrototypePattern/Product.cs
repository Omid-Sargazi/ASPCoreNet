using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class Product:IPrototype<Product>
    {
        public string Name {get; set;}
        public decimal Price {get; set;}

        public Product CLone()
        {
            return (Product)this.MemberwiseClone();
        }
    }

    
}