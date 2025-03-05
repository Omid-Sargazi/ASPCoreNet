using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.LoggingSystem
{
    public class EmailLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[Email Log] Sending email with message: {message}");
        }
    }
}