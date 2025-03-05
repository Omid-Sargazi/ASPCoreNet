using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public class DigitalProduct : IDigitalProduct
    {
        public int Id => throw new NotImplementedException();

        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DownloadUrl {get;}

        public DigitalProduct(int id, decimal price, string name, int quantity, string downloadUrl)
        {
            Price = price;
            Name = name;
            Quantity = quantity;
            DownloadUrl = downloadUrl;
        }

        public decimal CalculatePrice()
        {
            return Price;
        }

        public bool CheckAvailability()
        {
            return true;
        }

        public string GenerateDownloadLink()
        {
            return DownloadUrl;
        }
    }
}