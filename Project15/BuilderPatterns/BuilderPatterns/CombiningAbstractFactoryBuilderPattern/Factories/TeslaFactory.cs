using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPatterns.CarBuilder;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Factories
{
    public class TeslaFactory : ICar
    {
        public Car createSedan()
        {
            return new Car {Brand = "Tesla", Model="Model S"};
        }

        public Car createSport()
        {
            return new Car {Brand = "Tesla", Model="Roadster"};

        }

        public Car createSUV()
        {
            return new Car {Brand = "Tesla", Model="Model X"};

        }
    }
}