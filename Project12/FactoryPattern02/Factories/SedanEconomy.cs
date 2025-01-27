using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02.Factories
{
    public class SedanEconomy : ISedan
    {
        public void Capacity()
        {
            Console.WriteLine("Created a Economy Sadan with 4 seats");
        }

        public void Engine()
        {
            Console.WriteLine("Created a Economy Sadan with 1.2L engine");
        }
    }
}