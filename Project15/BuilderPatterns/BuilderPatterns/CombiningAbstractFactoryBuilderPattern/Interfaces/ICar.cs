using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPatterns.CarBuilder;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces
{
    public interface ICar
    {
        public Car createSedan();
        public Car createSUV();
        public Car createSport();
    }
}