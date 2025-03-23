using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example04
{
    public interface ITemperature
    {
        public double GetTemperatureInCelsius();
    }
}