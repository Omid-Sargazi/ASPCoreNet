namespace Patterns.StrategyPattern
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            return list.OrderBy(x => x).ToList();
        }
    }
}