using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Implements
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float _temperature;
        private float _humidity;
        public void Update(float temp, float humidity, float pressure)
        {
          _temperature = temp;
          _humidity = humidity;
          Display();

        }

        public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
    }
}