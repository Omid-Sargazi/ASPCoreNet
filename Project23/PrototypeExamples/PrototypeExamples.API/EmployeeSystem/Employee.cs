using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.EmployeeSystem
{
    public abstract class Employee
    {
        public string Name { get; set; } = "";
        public decimal Salary { get; set; } = 0;
        public int WeekelyHours { get; set; } = 0;

        public abstract Employee Clone();
    }
}