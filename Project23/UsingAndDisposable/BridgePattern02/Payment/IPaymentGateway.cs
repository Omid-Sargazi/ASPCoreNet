using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern02.Payment
{
    public interface IPaymentGateway
    {
        public void ProcessPayment(decimal amount);
    }
}