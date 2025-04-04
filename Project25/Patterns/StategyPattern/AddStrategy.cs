namespace Patterns.StrategyPattern
{
    public class AddStrategy : ICalculateStrategy
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}