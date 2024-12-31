using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class OrderDetail
    {
        public int OrderId {get;set;}
        public Order Order {get;set;} = null!;
        public int ProductId {get;set;}
        public Product Product {get;set;} = null!;
        public int Quantity {get;set;}
    }
}