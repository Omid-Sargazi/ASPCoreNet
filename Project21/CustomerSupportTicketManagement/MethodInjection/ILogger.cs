using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.MethodInjection
{
    public interface ILogger
    {
        void Log(string message);
    }
}