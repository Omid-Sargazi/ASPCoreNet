using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.PaymentProcessingSystem
{
    public class PayPalPayment : IPaymentMethod
    {
        public bool ProccessPayment(decimal amount) 
        {
           Console.WriteLine($"Processing PayPal Payment: ${amount}");
           return true;
        }
    }
}