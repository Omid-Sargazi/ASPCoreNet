namespace  StartegyPattern.DiscountStrategy
{
    public class SeasonalDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            if (price >= 5000m && price <= 15000m)
            {
                return price - (price * 0.15m); // ۱۵٪ تخفیف
            }
            return price; // بدون تخفیف
        }
    }
}