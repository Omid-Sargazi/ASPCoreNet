using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.LoggingSystem
{
    public class LoggingService
    {
        private readonly ILogger _logger;
        public LoggingService(ILogger logger)
        {
            _logger = logger;
        }

        public void ProcessLog(string message)
        {
            _logger.Log(message);
        }
    }
}