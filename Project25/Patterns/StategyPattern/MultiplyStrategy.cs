namespace Patterns.StrategyPattern
{
   public class MultiplyStrategy : ICalculateStrategy
   {
        public int Calculate(int a, int b)
         {
        return a * b; // ضرب
        }
   }

}