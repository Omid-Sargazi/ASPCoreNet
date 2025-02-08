using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements
{
    public class TeslaSport : ISports
    {
        public void Create()
        {
            Console.WriteLine("Create a sport Tesla");
        }
    }
}