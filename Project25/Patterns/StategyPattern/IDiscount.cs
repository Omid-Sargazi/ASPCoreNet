namespace Patterns.StrategyPattern
{
    public interface IDiscount
    {
        decimal CalculateDiscount(decimal price);
    }
}