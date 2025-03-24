using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern02.Payment
{
    public abstract class Payment
    {
        protected IPaymentGateway _gateway;
        public Payment(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public abstract void Pay(decimal amount);
    }
}