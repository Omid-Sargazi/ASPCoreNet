using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Tests.Payment
{
    public interface IPaymentService
    {
        bool ProcessPayment(decimal amount);
    }
}