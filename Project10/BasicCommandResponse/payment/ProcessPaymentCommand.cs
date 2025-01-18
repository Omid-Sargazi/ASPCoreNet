using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.payment
{
    public class ProcessPaymentCommand:Command
    {
        public double Amount {get; set;}
        public string PaymentMethod {get; set;}

        public ProcessPaymentCommand(double amount, string paymentMethod)
        {
            Amount = amount;
            paymentMethod = paymentMethod;
        }

    }
}