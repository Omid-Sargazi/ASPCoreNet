namespace Patterns.Example01
{
    public class Driver
    {
        public string Name;
        public void Drive(Car car)
        {
            Console.WriteLine($"{Name} is driving. a car {car.Brand}");
        }
    }
}