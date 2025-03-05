using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.PaymentProcessingSystem
{
    public class CreditCardPayment : IPaymentMethod
    {
        public bool ProccessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment: ${amount}");
            return true;
        }
    }
}