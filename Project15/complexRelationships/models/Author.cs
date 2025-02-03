using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complexRelationships.models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>(); // One-to-Many
        public AuthorContact Contact { get; set; } // One-to-One
    }
}