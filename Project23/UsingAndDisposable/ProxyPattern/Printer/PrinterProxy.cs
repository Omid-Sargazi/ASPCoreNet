using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.ProxyPattern.Printer
{
    public class PrinterProxy : IPrinter
    {
        private  RealPrinter _realPrinter;
        private bool _isEmployee;
        public PrinterProxy(bool isEmployee)
        {
            _isEmployee = isEmployee;
        }
        public void Print(string document)
        {
            if(_isEmployee)
            {
                if(_realPrinter == null)
                {
                    _realPrinter = new RealPrinter();
                }
                _realPrinter.Print(document);
            }else{
                Console.WriteLine("فقط کارمندان می‌توانند از پرینتر استفاده کنند!");
            }
        }
    }
}