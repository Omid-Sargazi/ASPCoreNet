using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIs.Models
{
    public class Author
    {
         public int Id { get; set; }
        public string Name { get; set; }

         // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}