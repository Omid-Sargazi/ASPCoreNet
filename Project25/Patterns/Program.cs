using Patterns.Example01;
namespace Patterns
{
    public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Color = "Red";

        myCar.Drive();
    }
}
}