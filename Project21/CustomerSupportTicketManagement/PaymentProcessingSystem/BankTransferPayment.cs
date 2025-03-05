using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.PaymentProcessingSystem
{
    public class BankTransferPayment : IPaymentMethod
    {
        public bool ProccessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bank Transfer: ${amount}");
            return true;
        }
    }
}