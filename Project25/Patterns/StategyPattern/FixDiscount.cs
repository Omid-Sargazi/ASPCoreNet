namespace Patterns.StrategyPattern
{
    public class FixDiscount : IDiscount
    {
        // private readonly decimal _discount;

        // public FixDiscount(decimal discount)
        // {
        //     _discount = discount;
        // }

        public decimal CalculateDiscount(decimal price)
        {
            return price * 0.5m;
        }
    }
}