using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.Temperature
{
    public interface ITemperature
    {
        public double GetTemperatureInCelsius();
    }
}