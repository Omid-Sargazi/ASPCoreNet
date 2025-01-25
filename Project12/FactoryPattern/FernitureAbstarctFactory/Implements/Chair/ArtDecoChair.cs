using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Implements.Chair
{
    public class ArtDecoChair:IChair
    {
        public void Create()
        {
            Console.WriteLine("ArtDeco Chair Created");
        }
    }
}