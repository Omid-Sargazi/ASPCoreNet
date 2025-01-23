using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests
{
    public class OrderProcessor
    {
        private readonly IOrderService _orderService;

        public OrderProcessor(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public bool CompleteOrder(int orderId)
        {
            return _orderService.ProcessOrder(orderId);
        }
    }
}