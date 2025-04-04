namespace Patterns.StrategyPattern
{
    public class SubtractStrategy : ICalculateStrategy
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}