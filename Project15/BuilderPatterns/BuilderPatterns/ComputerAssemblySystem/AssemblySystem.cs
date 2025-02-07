using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.ComputerAssemblySystem
{
    public class AssemblySystem
    {
        public string Processor {get; set;}
        public string RAM {get; set;}
        public string Storage {get; set;}
        public bool Graphic {get; set;}
        public bool OS {get; set;}


        public void showDetails()
        {
            Console.WriteLine($"Processor:{Processor}");
            Console.WriteLine($"RAM:{RAM}");
            Console.WriteLine($"Storage:{Storage}");
            Console.WriteLine(Graphic ? "Graphic":"No Graphic");
            Console.WriteLine(OS ? "Operation System":"No Operation System");
        }
    }
}