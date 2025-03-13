using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Models
{
    public class Employee:Person
    {
        public int EmployeeId {get; set;}
        public string getImployeeInfo()
        {
            return $"{getFullName()} {EmployeeId}";
        }   
    }
}