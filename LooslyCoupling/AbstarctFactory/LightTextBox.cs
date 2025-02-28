using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public class LightTextBox : ITextBox
    {
        public void CreateTextBox()
        {
            Console.WriteLine("Light Checkbox created");
        }
    }
}