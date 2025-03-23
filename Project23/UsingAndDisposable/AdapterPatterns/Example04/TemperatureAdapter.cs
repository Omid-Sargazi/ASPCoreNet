using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example04
{
    public class TemperatureAdapter : ITemperature
    {
        private readonly FahrenheitSensor _fahrenheitSensor;
        public TemperatureAdapter(FahrenheitSensor fahrenheitSensor)
        {
            _fahrenheitSensor = fahrenheitSensor;
        }
        public double GetTemperatureInCelsius()
        {
            var temp = _fahrenheitSensor.GetTemperatureInFahrenheit();
            return (temp - 32) * 5 / 9;
        }
    }
}