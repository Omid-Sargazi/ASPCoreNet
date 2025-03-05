using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.LoggingSystem
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            System.IO.File.AppendAllText("log.txt", $"{DateTime.Now}: {message}\n");
        }
    }
}