using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatterns.weatherForecastingApplication 
{
    public class WeatherData : ICloneable
    {
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        public WeatherData(int temp, int humidity)
        {
            Temperature = temp;
            Humidity = humidity;
        }
        public object Clone()
        {
            return (WeatherData)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Temperature: {Temperature}, Humidity {Humidity}");
        }
    }
}