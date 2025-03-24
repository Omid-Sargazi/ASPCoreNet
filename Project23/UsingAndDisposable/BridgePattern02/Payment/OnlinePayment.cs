using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern02.Payment
{
    public class OnlinePayment : Payment
    {
        public OnlinePayment(IPaymentGateway gateway) : base(gateway)
        {
        }

        public override void Pay(decimal amount)
        {
            _gateway.ProcessPayment(amount);
        }
    }
}