using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.CalculatorExample
{
    public class CalculatorProxy : ICalculator
    {
        private ICalculator _realCalculator;
        private Dictionary<string, double> _cache;

        public CalculatorProxy(ICalculator calculator)
        {
            _cache = new Dictionary<string, double>();
            _realCalculator = calculator;
        }
        public double Add(double a, double b)
        {
            string key = $"Add:{a}:{b}";
        LogOperation("Add", a, b);
        
        // Check cache first
        if (_cache.ContainsKey(key))
        {
            Console.WriteLine($"Returning cached result for {a} + {b}");
            return _cache[key];
        }

        double result = _realCalculator.Add(a, b);
        return result;
        }

        public double Divide(double a, double b)
        {
             if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero");
            return double.NaN; // Not a Number
        }
        
        string key = $"Divide:{a}:{b}";
        LogOperation("Divide", a, b);
        
        // Check cache first
        if (_cache.ContainsKey(key))
        {
            Console.WriteLine($"Returning cached result for {a} / {b}");
            return _cache[key];
        }
        
        // Perform calculation and cache the result
        double result = _realCalculator.Divide(a, b);
        _cache[key] = result;
        return result;
        }

        public double Multiply(double a, double b)
        {
             string key = $"Multiply:{a}:{b}";
        LogOperation("Multiply", a, b);
        
        // Check cache first
        if (_cache.ContainsKey(key))
        {
            Console.WriteLine($"Returning cached result for {a} * {b}");
            return _cache[key];
        }
        
        // Perform calculation and cache the result
        double result = _realCalculator.Multiply(a, b);
        _cache[key] = result;
        return result;
        }

        public double Subtract(double a, double b)
        {
             string key = $"Subtract:{a}:{b}";
        LogOperation("Subtract", a, b);
        
        // Check cache first
        if (_cache.ContainsKey(key))
        {
            Console.WriteLine($"Returning cached result for {a} - {b}");
            return _cache[key];
        }

        double result = _realCalculator.Subtract(a, b);
        return result;
        }






         private void LogOperation(string operation, double a, double b)
    {
        Console.WriteLine($"{DateTime.Now} - Performing {operation} operation with inputs {a} and {b}");
    }
    }
}