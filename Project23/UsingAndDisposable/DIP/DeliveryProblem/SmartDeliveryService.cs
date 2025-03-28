using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.DIP.OrderProduct.OldOrderProduct;

namespace UsingAndDisposable.DIP.DeliveryProblem
{
    public class SmartDeliveryService
    {
        private readonly IDeliveryLogger _deliveryLogger;
        private readonly IDeliveryMethod _deliveryMethod;
        private Order order;

        public SmartDeliveryService(IDeliveryLogger deliveryLogger, IDeliveryMethod deliveryMethod)
        {
            _deliveryLogger = deliveryLogger;
            _deliveryMethod = deliveryMethod;
        }

        public void ProcessDelivery()
        {
            var cost = _deliveryMethod.CalculateCost(order);
        }
    }
}