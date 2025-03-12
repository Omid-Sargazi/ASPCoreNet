using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Injection
{
    public class ConsoleLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }
}