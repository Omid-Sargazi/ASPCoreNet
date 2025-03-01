using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.EmployeeManagementSystem
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee> 
            {
                new Employee { Id = 1, Name = "Alice", IsActive = true },
                new Employee { Id = 2, Name = "Bob", IsActive = false }
            };
        }
    }
}