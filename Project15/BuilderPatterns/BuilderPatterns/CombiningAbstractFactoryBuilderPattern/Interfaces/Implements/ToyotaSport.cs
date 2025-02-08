using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements
{
    public class ToyotaSport : ISports
    {
        public void Create()
        {
            Console.WriteLine("Created a sport toyota");
        }
    }
}