using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupportTicketManagement.PaymentProcessingSystem
{
    public interface IPaymentMethod
    {
        bool ProccessPayment(decimal amount);
    }
}