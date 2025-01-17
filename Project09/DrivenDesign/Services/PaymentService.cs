using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrivenDesign.Aggregations;

namespace DrivenDesign.Services
{
    public class PaymentService
    {
         public void ProcessPayment(Order order, decimal amount)
    {
        // Logic for processing payment
        Console.WriteLine($"Processing payment of {amount} for order {order.Id}");
    }
    }
}