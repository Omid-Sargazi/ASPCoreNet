using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuilderPatterns.CarBuilder;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Factories;
using BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces;


namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern
{
    public class ClientCarFactory
    {

        public static void Main()
        {
            ICar cargactory = new ToyotaFactory();
            Car bascar = cargactory.createSedan();

            Car customeCar = new BuilderPatterns.CarBuilder.CarBuilder(bascar)
            .setEngine("V8 turbu")
            .setColor("green")
            .setWheels("sport Alley")
            .setSunroof()
            .car();
        }
    
    }
}