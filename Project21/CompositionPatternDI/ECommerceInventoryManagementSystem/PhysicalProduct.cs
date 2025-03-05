using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public class PhysicalProduct : IPhysicalProduct
    {
        public int Id {get;}
        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Weight {get;}


        public PhysicalProduct(int id, decimal price, string name, int quantity)
        {
            Id = id;
            Price = price;
            Name = name;
            Quantity = quantity;
        }

        public decimal CalculatePrice()
        {
            return Price;
        }

        public decimal CalculateShippingCost()
        {
            return 0.5m * Weight;
        }

        public bool CheckAvailability()
        {
            return Quantity >0;
        }
    }
}