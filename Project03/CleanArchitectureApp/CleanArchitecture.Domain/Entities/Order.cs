using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Order:BaseEntity
    {
        public string CustomerName {get;private set;}
        public decimal TotalAmount {get; private set;}


        public Order(string customerName, decimal totalAmount)
        {
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }
    }
}