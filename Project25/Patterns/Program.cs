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

        ////////////////////////
        var englsih = new EnglishGreeting();
        var spanish = new SpanishGreeting();
        var french = new FrenchGreeting();
        Console.WriteLine(engine.SayHello());
        Console.WriteLine(spanish.SayHello());
        Console.WriteLine(french.SayHello());

    }
}
}