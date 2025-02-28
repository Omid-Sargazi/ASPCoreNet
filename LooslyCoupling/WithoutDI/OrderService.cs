using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.WithoutDI
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        public IEnumerable<Order> GetPendingOrders()
        {
            return _orderRepository.GetAll().Where(o => o.Status == "Pending");
        }
    }
}