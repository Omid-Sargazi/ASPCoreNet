namespace  StartegyPattern.DiscountStrategy
{
    public class DiscountCalculator
    {
        private readonly IDiscount _discountStrategy;

        public DiscountCalculator(IDiscount discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculatePrice(decimal price)
        {
            return _discountStrategy.CalculateDiscount(price);
        }
    }
}