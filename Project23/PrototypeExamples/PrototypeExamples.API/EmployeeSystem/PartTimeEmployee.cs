using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.EmployeeSystem
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee()
        {
            Name = "Part Time Employee";
            Salary = 32000m;
            WeekelyHours = 20;
        }
        public override Employee Clone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}