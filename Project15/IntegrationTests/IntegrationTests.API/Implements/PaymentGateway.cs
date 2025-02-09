using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntegrationTests.API.Interfaces;

namespace IntegrationTests.API.Implements
{
    public class PaymentGateway : IPaymentGateway
    {
        public async Task<bool> ProcessPaymentAsync(decimal amount)
        {
            await Task.Delay(1000);
            return amount > 0;
        }
    }
}