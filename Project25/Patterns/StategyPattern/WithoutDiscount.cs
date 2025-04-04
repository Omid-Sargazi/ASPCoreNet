namespace Patterns.StrategyPattern
{
    public class WithoutDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price;
        }
    }
}