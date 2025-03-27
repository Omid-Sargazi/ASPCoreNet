using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.DIP.OrderProduct.OldOrderProduct;

namespace UsingAndDisposable.DIP.DeliveryProblem
{
    public class CarDelivery : IDeliveryMethod
    {
        public decimal CalculateCost(Order order)
        {
            return 8.00m;
        }

        public void Deliver(Order order)
        {
            throw new NotImplementedException();
        }
    }
}