namespace Patterns.StrategyPattern
{
    public class TenPercentDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            return price * 0.10m;
        }
    }
}