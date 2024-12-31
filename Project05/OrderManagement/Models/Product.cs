using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class Product
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public decimal Price {get;set;}
        public ICollection<OrderDetail> orderDetails {get;set;} = new List<OrderDetail>();

    }
}