using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactory.Interfaces;

namespace AbstarctFactory.Factories
{
    public class MacFileLogger : IFileLogger
    {
        public void logFile()
        {
        Console.WriteLine("File logged by Mac.");
            
        }
    }
}