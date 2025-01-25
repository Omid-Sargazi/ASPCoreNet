using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Implements.Sofa
{
    public class VictorianSofa:ISopha
    {
        public void Create()
        {
            Console.WriteLine("Victorian Sofa Created");
        }
    }
   
}