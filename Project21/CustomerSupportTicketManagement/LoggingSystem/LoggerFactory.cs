using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.LoggingSystem
{
    public class LoggerFactory
    {
        public static LoggingService CreateLoggingService(string loggerType)
        {
            ILogger logger = loggerType switch
            {
                "console" => new ConsoleLogger(),
                "file" => new FileLogger(),
                "email" => new EmailLogger(),
                _ => throw new ArgumentException("Invalid logger type")
            };

            return new LoggingService(logger);
        }
    }
}