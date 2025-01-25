using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Implements.Sofa
{
    public class ModernSofa:ISopha
    {
        public void Create()
        {
            Console.WriteLine("Modern Sofa Created");
        }
    }
    
}