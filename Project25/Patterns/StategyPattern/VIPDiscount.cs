namespace Patterns.StrategyPattern
{
    public class VIPDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal price)
        {
            if(price > 10000m)
            {
                return price * 0.2m;
            }
            return price * 0.1m;
        }
    }
}