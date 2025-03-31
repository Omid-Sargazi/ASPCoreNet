namespace Test.Patterns.Temp
{
    public class AlarmSystem : IObserver
    {
        public void Update(double temperature)
        {
            if(temperature > 35)
            {
                Console.WriteLine("AlarmSystem: Warning! Temperature is critical!");
            }
        }
    }
}