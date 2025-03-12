using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day03CSharp.Models
{
    public class People(string name, int age)
    {
        public void DisplayInfo() => Console.WriteLine($"Student's name is {name} with age {age}");
    }
}