using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements
{
    public class BMWSedan : ISedan
    {
        public void Create()
        {
            Console.WriteLine("Created a sedan BMW");
        }
    }
}