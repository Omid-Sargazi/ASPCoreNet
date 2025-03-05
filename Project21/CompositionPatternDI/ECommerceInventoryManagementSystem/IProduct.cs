using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public interface IProduct
    {
        public int Id {get;}
        public decimal Price {get; set;}
        public string Name {get; set;}
        public int  Quantity {get; set;}
        public decimal CalculatePrice();
        public bool CheckAvailability();

    }
}