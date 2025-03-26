using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.ProxyPattern.Printer
{
    public class RealPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"پرینت شد: {document}");
        }
    }
}