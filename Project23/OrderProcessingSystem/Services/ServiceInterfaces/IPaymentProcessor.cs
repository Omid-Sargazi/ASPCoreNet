using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Services.ServiceInterfaces
{
    public interface IPaymentProcessor
    {
        Task<PaymentResult> ProcessPaymentAsync(Customer customer, decimal amount, PaymentMethod paymentMethod);
        Task<bool> RefundPaymentAsync(string transactionId);
    }
}