using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LooslyCoupling.WithDI
{
    public class OrderController:Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly OrderService _orderService;

        public IActionResult Index()
        {
            var order = _orderService.GetPendingOrders();
            return View(order);
        }
    }
}