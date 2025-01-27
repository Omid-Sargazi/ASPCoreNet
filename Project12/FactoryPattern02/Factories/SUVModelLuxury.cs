using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern02.Interfaces;

namespace FactoryPattern02.Factories
{
    public class SUVModelLuxury:ISUVModel
    {
        public void Engine()
        {
            Console.WriteLine("Engine: 3.0L V6");
        }

        public void Capacity()
        {
            Console.WriteLine("Capacity: 7");
        }
    }
 
}