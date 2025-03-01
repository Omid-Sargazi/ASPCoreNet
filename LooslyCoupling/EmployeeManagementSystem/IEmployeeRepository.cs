using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.EmployeeManagementSystem
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetAll();
    }
}