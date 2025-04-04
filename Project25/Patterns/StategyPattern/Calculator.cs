namespace Patterns.StrategyPattern
{
    public class Calculator
    {
        private readonly ICalculateStrategy __strategy;
        public Calculator(ICalculateStrategy strategy)
        {
            __strategy = strategy;
        }
        public void SetStrategy(ICalculateStrategy strategy)
        {
            __strategy = strategy;
        }

        public int PerformCalculation(int a, int b)
        {
            return __strategy.Calculate(a, b);
        }
    }
}