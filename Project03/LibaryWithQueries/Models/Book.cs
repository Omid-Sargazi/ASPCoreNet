using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibaryWithQueries.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Order> Orders { get; set; }
        public decimal Price {get;set;}
    }
}