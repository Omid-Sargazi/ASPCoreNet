using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.CombiningAbstractFactoryBuilderPattern.Interfaces.Implements
{
    public class ToyotaSUV : ISUV
    {
        public void Create()
        {
            Console.WriteLine("Create a toyota suv ");
        }
    }
}