using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02.Factories
{
    public class SUVModelEconomy:ISUVModel
    {
        public void Engine()
        {
            Console.WriteLine("Engine: 1.5L");
        }

        public void Capacity()
        {
            Console.WriteLine("Capacity: 5");
        }
    }
   
}