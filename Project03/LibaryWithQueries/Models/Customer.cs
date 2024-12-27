using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibaryWithQueries.Models
{
    public class Customer
    {
         public int CustomerId { get; set; }
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}