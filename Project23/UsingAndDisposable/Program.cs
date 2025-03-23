using UsingAndDisposable;
using UsingAndDisposable.AdapterPatterns.Example04;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        using(StreamWriter writer = new StreamWriter("example.txt"))
        {
            writer.WriteLine("Hello World");
        }
        Console.WriteLine("The file has been written");

        using(FileManager fm = new FileManager("temp.txt"))
        {
            fm.Write("this is a test");
        }
        Console.WriteLine("کار تموم شد!");   

        FahrenheitSensor fahrenheitSensor = new FahrenheitSensor();
        ITemperature temperature = new TemperatureAdapter(fahrenheitSensor);
                Console.WriteLine($"Temperature in Celsius: {temperature.GetTemperatureInCelsius()}");

    }

}