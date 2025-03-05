using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public class SubscriptionProduct : ISubscriptionProduct
    {
         int SubscriptionLength {get;}

         decimal RenewalPrice {get;}

         int Id {get;}

        public decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Quantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int ISubscriptionProduct.SubscriptionLength => SubscriptionLength;

        decimal ISubscriptionProduct.RenewalPrice => RenewalPrice;

        int IProduct.Id => Id;

        public SubscriptionProduct(int id, string name, decimal price, int subscriptionLength, decimal renewalPrice)
       {
            id = Id;
            Name = name;
            Price = price;
            SubscriptionLength = subscriptionLength;
            RenewalPrice = renewalPrice;
       }

        public decimal CalculatePrice()
        {
           return Price;
        }

        public bool CheckAvailability()
        {
            return true;
        }

        public void RenewSubscription()
        {
            Console.WriteLine("Subscription renewed for " + SubscriptionLength + " months.");
    
        }
    }
}