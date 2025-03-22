using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.Printer
{
    public interface IPrinter
    {
        public void Print(string context);
    }
}