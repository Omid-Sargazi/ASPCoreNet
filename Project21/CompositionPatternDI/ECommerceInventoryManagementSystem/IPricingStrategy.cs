using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public interface IPricingStrategy
    {
        decimal ApplyDiscount(IProduct product);
    }
}