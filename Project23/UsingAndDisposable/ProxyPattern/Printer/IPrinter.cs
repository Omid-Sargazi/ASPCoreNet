using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.ProxyPattern.Printer
{
    public interface IPrinter
    {
        public void Print(string document);
    }
}