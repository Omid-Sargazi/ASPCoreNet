using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleProject.Entities;
using ExampleProject.Repositories;

namespace ExampleProject.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;

        public OrderService(IOrderRepository orderRepository, ICustomerRepository customerRepository)
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
        }

        public void PlaceOrder(Guid customerId, List<OrderItem> items)
        {
            var customer = _customerRepository.GetById(customerId);
            if (customer == null)
                throw new Exception("Customer not found.");

            var order = new Order(customerId);
            items.ForEach(order.AddItem);

            _orderRepository.Save(order);
        }

        public Order GetOrder(Guid orderId)
        {
            return _orderRepository.GetById(orderId);
        }
    }
}