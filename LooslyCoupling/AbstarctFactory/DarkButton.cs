using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public class DarkButton : IButton
    {
        public void CreateButton()
        {
            Console.WriteLine("Darkt Button Checkbox created");
        }
    }
}