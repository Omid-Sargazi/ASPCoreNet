using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.MethodInjection
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divided(int a, int b, ILogger logger)
        {
            if(b ==0)
            {
                logger.Log("Division by zero attemoted.");
            }

            return a/b;
        }
    }
}