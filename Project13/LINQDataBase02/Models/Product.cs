using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQDataBase02.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public decimal Price {get; set;}
        public int CategoryId {get; set;}
        public Category Category {get; set;}
    }
}