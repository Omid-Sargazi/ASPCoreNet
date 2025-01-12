using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Entities
{
    public class Invoice
    {
        public Guid Id {get; protected set;}
        public Guid OrderId {get; protected set;}
        public decimal TotalAmount {get; protected set;}
        public DateTime IssuedDate {get; protected set;}



        public Invoice(Guid orderId, decimal totalAmount)
        {
            if(totalAmount<=0)
                throw new Exception("Total amount must be positive.");

            Id = Guid.NewGuid();
            OrderId = orderId;
            TotalAmount = totalAmount;
            IssuedDate = DateTime.UtcNow;             
        }
    }
}