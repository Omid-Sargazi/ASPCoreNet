using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingSystem.Services
{
    public class OrderResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public string TransactionId { get; set; }
    }
}