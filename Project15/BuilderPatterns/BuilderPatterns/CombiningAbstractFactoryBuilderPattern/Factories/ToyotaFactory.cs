using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPatterns.CarBuilder;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Factories
{
    public class ToyotaFactory : ICar
    {
        public Car createSedan()
        {
            return new Car {Brand = "Toyota", Model = "Camry"};
        }

        public Car createSport()
        {
            return new Car {Brand="Toyota", Model="Supra"};
        }

        public Car createSUV()
        {
            return new Car {Brand = "Toyota", Model = "Rav4"};
        }
    }
}