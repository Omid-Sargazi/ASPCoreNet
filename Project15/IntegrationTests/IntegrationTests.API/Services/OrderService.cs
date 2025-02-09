using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.API.Interfaces;

namespace IntegrationTests.API.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IPaymentGateway _paymentGateway;

        public OrderService(IOrderRepository orderRepository, IPaymentGateway paymentGateway)
        {
            _orderRepository = orderRepository;
            _paymentGateway = paymentGateway;
        }

        public async Task<bool> ProcessOrderAsync(int orderId)
        {
            var order = await _orderRepository.GetOrderAsync(orderId);
            if(order == null)
                throw new ArgumentException("Order not found");
            
            var paymentResult = await _paymentGateway.ProcessPaymentAsync(order.TotalAmount);
            if(paymentResult)
            {
                order.IsPaid = true;
                await _orderRepository.SaveOrderAsync(order);

            }

            return paymentResult;
        }
    }
}