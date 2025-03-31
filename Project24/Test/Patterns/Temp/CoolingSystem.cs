namespace Test.Patterns.Temp
{
    public class CoolingSystem : IObserver
    {
        public void Update(double temperature)
        {
            if(temperature > 30)
            {
                Console.WriteLine("CoolingSystem: Temperature is too high! Cooling down...");
            }
        }
    }
}