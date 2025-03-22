using AdapterPattern.Temperature;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        ITemperature sensore = new TemperatureAdapter();
        Console.WriteLine($"Temperature in Celsius: {sensore.GetTemperatureInCelsius()}");
    }
}