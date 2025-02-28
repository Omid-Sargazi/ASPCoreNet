using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIPractice.DISecodeProject
{
    public class WriteAMessage : IWriteAMessage
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}