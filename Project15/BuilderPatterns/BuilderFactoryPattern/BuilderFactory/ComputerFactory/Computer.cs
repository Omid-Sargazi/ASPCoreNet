using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderFactory.ComputerFactory
{
    public class Computer
    {
        public string CPU {get; set;}
        public string RAM {get; set;}
        public string GPU {get; set;}
        public string Storage {get; set;}


        public void Display()
        {
             Console.WriteLine($"Computer Configuration:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"GPU: {GPU ?? "Not Specified"}");
            Console.WriteLine($"Storage: {Storage}");
        }
    }
}