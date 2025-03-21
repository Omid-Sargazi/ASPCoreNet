using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.EmployeeSystem
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
            Name = "Full Time Employee";
            Salary = 60000.0m;
            WeekelyHours = 40;
        }
        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
    }
}