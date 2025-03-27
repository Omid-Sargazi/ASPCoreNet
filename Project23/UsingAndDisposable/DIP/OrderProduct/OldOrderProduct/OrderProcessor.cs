using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.OrderProduct.OldOrderProduct
{
    public class OrderProcessor
    {
        private readonly PayPalGateway _payPalGateway;
        private readonly FileLogger _fileLogger;

        public OrderProcessor()
        {
            _fileLogger = new FileLogger();
            _payPalGateway = new PayPalGateway();
        }

        public void ProcessOrder(Order order)
        {
            _fileLogger.Log();
            _payPalGateway.ProcessPayment();
            _fileLogger.Log();
        }
    }
}