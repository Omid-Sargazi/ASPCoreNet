using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.InventoryManagementSystem
{
    public class ProductOfSystem:ICloneable
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Price {get; set;}
        public int Stock {get; set;}

        public object Clone()
        {
            return (ProductOfSystem) this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price}, Stock: {Stock}";
         }
    }
}