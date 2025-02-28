using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LooslyCoupling.WithoutDI
{
    public class OrderController:Controller
    {
        public IActionResult Index()
        {
            var repo = new OrderRepository();
            var service = new OrderService(repo);
            var orders = service.GetPendingOrders();
            return View(orders);
        }   
    }
}