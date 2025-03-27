using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.DIP.OrderProduct.OldOrderProduct;

namespace UsingAndDisposable.DIP.DeliveryProblem
{
    public class MotorcycleDelivery : IDeliveryMethod
    {
        public decimal CalculateCost(Order order)
        {
            return 0.5m;
        }

        public void Deliver(Order order)
        {
            throw new NotImplementedException();
        }
    }
}