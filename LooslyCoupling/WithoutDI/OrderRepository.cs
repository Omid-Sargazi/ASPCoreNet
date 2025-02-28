using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.WithoutDI
{
    public class OrderRepository
    {
        private readonly SqlConnection _connection; 

        public OrderRepository()
        {
            _connection = new SqlConnection("Server=localhost;Database=OrdersDB;User Id=sa;Password=12345;");   
        }

        public IEnumerable<Order> GetAll()
        {
            return new List<Order> 
            {
                new Order { Id = 1, Status = "Pending" },
                new Order { Id = 2, Status = "Shipped" }
            };
        }
    }
}