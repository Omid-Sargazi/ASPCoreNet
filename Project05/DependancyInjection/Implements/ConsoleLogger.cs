using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependancyInjection.Interfaces;

namespace DependancyInjection.Implements
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}