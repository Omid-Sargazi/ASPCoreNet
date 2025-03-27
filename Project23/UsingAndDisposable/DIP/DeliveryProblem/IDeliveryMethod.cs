using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.DIP.OrderProduct.OldOrderProduct;

namespace UsingAndDisposable.DIP.DeliveryProblem
{
    public interface IDeliveryMethod
    {
        public void Deliver(Order order);
        public void CalculateCost(Order order);
    }
}