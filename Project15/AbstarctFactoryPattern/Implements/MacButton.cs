using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.interfaces;

namespace AbstarctFactoryPattern.Implements
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Created a button by MAc");
        }
    }
}