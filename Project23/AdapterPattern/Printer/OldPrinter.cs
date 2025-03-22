using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.Printer
{
    public class OldPrinter
    {
        public void PrintText(string text)
        {
            Console.WriteLine($"Printing text:{text}");
        }
    }
}