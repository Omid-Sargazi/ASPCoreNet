using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.PaymentProcessingSystem
{
    public class PaymentCompositionRoot
    {
        public static PaymentService CreatePaymentService(string paymentType)
        {
            IPaymentMethod paymentMethod = paymentType switch
            {
                "creditcard" => new CreditCardPayment(),
                "paypal" => new PayPalPayment(),
                "banktransfer" => new BankTransferPayment(),
                _ => throw new ArgumentException("invalid payment method"),
            };

            return new PaymentService(paymentMethod);
        }
    }
}