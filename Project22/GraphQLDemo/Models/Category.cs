using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.Models
{
    public class Category
    {
         public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<product> Products { get; set; } = new List<product>();
    }
}