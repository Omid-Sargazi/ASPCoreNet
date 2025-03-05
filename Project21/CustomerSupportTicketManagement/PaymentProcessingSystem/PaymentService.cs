using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.PaymentProcessingSystem
{
    public class PaymentService
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentService(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public bool MakePayment(decimal amount)
        {
            _paymentMethod.ProccessPayment(amount);
            return true;
        }
    }
}