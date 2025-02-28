using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public class DarkCheckbox : ICheckbox
    {
        public void CreateCheckbox()
        {
            Console.WriteLine("Dark CheckBox Created.");
        }
    }
}