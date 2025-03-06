using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.MethodInjection
{
    public class ConsoleLoggerr : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"LOG: {message}");
        }
    }
}