using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIPractice.DIFirstProject
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}