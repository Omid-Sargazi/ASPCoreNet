using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests01.Domain.Models
{
    public class Author
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}