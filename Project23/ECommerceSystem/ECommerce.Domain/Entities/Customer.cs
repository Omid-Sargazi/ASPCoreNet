using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; 
        public ICollection<Order> Orders {get; set;} = new List<Order>();  
    }
}