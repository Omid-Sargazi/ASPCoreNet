using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LooslyCoupling.WithoutDI;

namespace LooslyCoupling.WithDI
{
    public class OrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;   
        }   

        public IEnumerable<Order> GetPendingOrders()
        {
            return _orderRepository.GetAll().Where(o => o.Status == "Pending");
        }
    }
}