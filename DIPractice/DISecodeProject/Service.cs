using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIPractice.DISecodeProject
{
    public class Service
    {
        private readonly IPrinter _printer;
        public Service(IPrinter printer)
        {
            _printer = printer;             
        }

        public void print(string message)
        {
            _printer.Print(message);
        }
    }
}