using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02.Factories
{
    public class SedanLuxury : ISedan
    {
        public void Capacity()
        {
            Console.WriteLine("Created a Luxury Sadan with 4 seats");
        }

        public void Engine()
        {
            Console.WriteLine("Created a Luxury Sedan With 1.2 engine");
        }
    }
}