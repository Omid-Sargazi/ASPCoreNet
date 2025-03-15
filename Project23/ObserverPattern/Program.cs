using ObserverPattern.Implements;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("hello");
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay();

        weatherData.RegisterObserver(currentDisplay);

        weatherData.SetMeasurements(80,65,34.1f);
        weatherData.SetMeasurements(70,13,33.1f);
    }
}
