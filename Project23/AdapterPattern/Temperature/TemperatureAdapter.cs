using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.Temperature
{
    public class TemperatureAdapter : FahrenheitSensor, ITemperature
    {

        public double GetTemperatureInCelsius()
        {
           double fahrenheit =  GetTemperatureInFahrenheit();
          return (fahrenheit-32)*5/9;

        }
    }
}