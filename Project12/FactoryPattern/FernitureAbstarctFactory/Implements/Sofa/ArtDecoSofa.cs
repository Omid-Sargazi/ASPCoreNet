using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Implements.Sofa
{
    public class ArtDecoSofa:ISopha
    {
        public void Create()
        {
            Console.WriteLine("ArtDeco Sofa Created");
        }
    }
   
}