using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Implements.Table
{
    public class ArtDecoTable:ITable
    {
        public void Create()
        {
            Console.WriteLine("ArtDeco Table Created");
        }
    }
}