using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example05
{
    public class PrinterAdapter : IPrinter
    {
        private readonly OldPrinter _oldPrinter;
        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }
        public void Print(string context)
        {
            string textContent = $"Converted PDF to text: {context}";
            _oldPrinter.PrintText(context);
        }
    }
}