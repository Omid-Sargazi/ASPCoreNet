using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public class LightCheckbox : ICheckbox
    {
        public void CreateCheckbox()
        {
            Console.WriteLine("Light Checkbox created");
        }
    }
}