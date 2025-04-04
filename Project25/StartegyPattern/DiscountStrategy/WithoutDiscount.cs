namespace  StartegyPattern.DiscountStrategy
{
   public class WithoutDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price; // بدون تخفیف
        }
    }
}