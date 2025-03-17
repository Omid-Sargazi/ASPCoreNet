using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.CalculatorExample
{
    public class CalculatorService : ICalculator
    {
        public double Add(double a, double b)
        {
            return a+b;
        }

        public double Divide(double a, double b)
        {
            return a/b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}