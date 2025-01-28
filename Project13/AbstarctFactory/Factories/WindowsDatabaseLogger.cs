using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactory.Interfaces;

namespace AbstarctFactory.Factories
{
    public class WindowsDatabaseLogger : IDatabaseLogger
    {
        public void logFile()
        {
        
        Console.WriteLine("Database logged by windows.");

        }
    }
}