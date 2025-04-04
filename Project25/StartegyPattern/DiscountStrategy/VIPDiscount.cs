namespace  StartegyPattern.DiscountStrategy
{
    public class VIPDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            if (price > 10000m)
            {
                return price - (price * 0.20m); // ۲۰٪ تخفیف
            }
            return price - (price * 0.05m); // ۵٪ تخفیف
        }
    }
}