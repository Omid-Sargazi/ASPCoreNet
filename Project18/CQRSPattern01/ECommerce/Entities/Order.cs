using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities
{
    public class Order
    {
        public Guid Id {get; set;} = Guid.NewGuid();
        public string CustomerName { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    }
}