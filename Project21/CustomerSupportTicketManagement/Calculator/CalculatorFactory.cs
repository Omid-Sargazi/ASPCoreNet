using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.Calculator
{
    public class CalculatorFactory
    {
        public static ICalculator CreateCalculator(string operation)
        {
            return operation switch
            {
                "Add" => new AddCalculator(),
                "subtract" => new SubtractCalculator(),
                _ => throw new ArgumentException("Onvalid operation"),
            };
        }
    }
}