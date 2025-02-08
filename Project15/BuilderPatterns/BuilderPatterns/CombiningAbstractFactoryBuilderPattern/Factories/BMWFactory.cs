using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPatterns.CarBuilder;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Factories
{
    public class BMWFactory : ICar
    {
        public Car createSedan()
        {
            return new Car {Brand = "BMW", Model = "3 Series"};
        }

        public Car createSport()
        {
            return new Car {Brand = "BMW", Model = "M4"};
        }

        public Car createSUV()
        {
            return new Car {Brand = "BMW", Model = "X5"};
        }
    }
}