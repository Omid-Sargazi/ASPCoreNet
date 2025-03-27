using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.DIP.OrderProduct.OldOrderProduct;

namespace UsingAndDisposable.DIP.OrderProduct.NewOldProduct
{
    public class OrderProcessor
    {
        private readonly IPaymentGateway _paymentGateway;
        private readonly ILogger _logger;

        public OrderProcessor(IPaymentGateway paymentGateway, ILogger logger)
        {
            _logger = logger;
            _paymentGateway = paymentGateway;
        }

        public void ProcessOrder(Order order)
        {
            _logger.Log("Processing order...");
            _paymentGateway.ProcessPayment(12.3m);
             _logger.Log("Order processed successfully");
        }
    }
}