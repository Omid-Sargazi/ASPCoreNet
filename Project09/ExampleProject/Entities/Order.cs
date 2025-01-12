using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Entities
{
    public class Order
    {
        public Guid Id {get; protected set;}
        public Guid CustomerId {get; protected set;}

        public DateTime OrderDate {get; protected set;}
        public List<OrderItem> OrderItems {get; protected set;}


        public Order(Guid customerId)
        {
            Id = Guid.NewGuid();
            CustomerId = customerId;
            OrderDate = DateTime.UtcNow;
        }


        public decimal CalculateTotalAmount()
        {
            return 11m;
        }

    }
}