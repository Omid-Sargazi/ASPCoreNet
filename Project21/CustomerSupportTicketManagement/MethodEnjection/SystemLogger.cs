using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.MethodEnjection
{
    public class SystemLogger : ILogger
    {
        public void Log(string message)
        {
           Console.WriteLine($"INFO: {DateTime.Now} - {message}");  
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ERROR: {DateTime.Now} - {message}");
            Console.ResetColor();
        }
    }
}