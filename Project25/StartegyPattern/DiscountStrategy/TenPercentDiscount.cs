namespace  StartegyPattern.DiscountStrategy
{
    public class TenPercentDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price - (price * 0.10m); // قیمت بعد از ۱۰٪ تخفیف
        }
    }
}