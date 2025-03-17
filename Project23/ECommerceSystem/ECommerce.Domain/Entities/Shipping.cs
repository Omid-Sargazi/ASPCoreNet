using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Shipping:BaseEntity
    {
         public int OrderId { get; set; }
        public Order Order { get; set; }
        public string ShippingAddress { get; set; } = string.Empty;   
    }
}