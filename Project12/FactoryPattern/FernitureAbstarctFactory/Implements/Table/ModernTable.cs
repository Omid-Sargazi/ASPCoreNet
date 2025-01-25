using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.FernitureAbstarctFactory.Interfaces;

namespace FactoryPattern.FernitureAbstarctFactory.Implements.Table
{
    public class ModernTable:ITable
    {
        public void Create()
        {
            Console.WriteLine("Modern Table Created");
        }
    }
   
}