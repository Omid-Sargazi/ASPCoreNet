using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public interface ISubscriptionProduct:IProduct
    {
         int SubscriptionLength {get;}
         decimal RenewalPrice {get;}
        void RenewSubscription();

    }
}