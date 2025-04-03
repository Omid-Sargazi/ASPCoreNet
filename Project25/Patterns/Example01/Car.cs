namespace Patterns.Example01
{
    public class Car
    {
        public string Brand;
        public string Color;

        public void Drive()
        {
            Console.WriteLine($"{Brand} is driving.");
        }
    }
}