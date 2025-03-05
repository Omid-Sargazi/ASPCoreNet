using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.Calculator
{
    public class SubtractCalculator : ICalculator
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}