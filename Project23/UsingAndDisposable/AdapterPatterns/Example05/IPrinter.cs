using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Example05
{
    public interface IPrinter
    {
        public void Print(string context);
    }
}