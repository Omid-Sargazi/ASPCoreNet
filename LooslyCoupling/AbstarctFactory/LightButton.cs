using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public class LightButton : IButton
    {
        public void CreateButton()
        {
            Console.WriteLine("Light Button Checkbox created");
        }
    }
}