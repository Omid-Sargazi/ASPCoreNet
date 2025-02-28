using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LooslyCoupling.WithoutDI;

namespace LooslyCoupling.WithDI
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetAll()
        {
            return new  List<Order> 
            {
                new Order { Id = 1, Status = "Pending" },
                new Order { Id = 2, Status = "Shipped" }
            };
        }
    }
}