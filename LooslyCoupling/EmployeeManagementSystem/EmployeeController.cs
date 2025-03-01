using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LooslyCoupling.EmployeeManagementSystem
{
    public class EmployeeController:Controller
    {
        private readonly EmployeeService _service;

        public EmployeeController(EmployeeService service)
        {
            _service = service;
        }
        
        public IActionResult Index()
        {
            var item = _service.GetActiveEmployees();
            return View(item);
        }
    }
}