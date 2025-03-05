using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.ECommerceInventoryManagementSystem
{
    public class PercentageDiscountStrategy : IPricingStrategy
    {
        private readonly decimal _percentage;

        public PercentageDiscountStrategy(decimal percentage)
        {
            _percentage = percentage;
        }
        public decimal ApplyDiscount(IProduct product)
        {
           return product.CalculatePrice() * _percentage;
        }
    }
}