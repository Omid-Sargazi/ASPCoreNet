using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.Models
{
    public class Report : ICloneable
    {
        public string Header {get; set;}
        public string Footer {get; set;}
        public List<string> Data {get; set;}

        public Report(string header, string footer)
        {
            Header = header;
            Footer = footer;
            Data = new List<string>();
        }
        public object Clone()
        {
            return(Report)this.MemberwiseClone();
        }

        public void Print()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Footer: {Footer}");
            foreach(var item in Data)
            {
                Console.WriteLine($"-{item}");
            }
            Console.WriteLine($"Footer:{Footer}");
        }
    }
}