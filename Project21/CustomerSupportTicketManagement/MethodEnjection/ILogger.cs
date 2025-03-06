using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.MethodEnjection
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(string message);
    }
}