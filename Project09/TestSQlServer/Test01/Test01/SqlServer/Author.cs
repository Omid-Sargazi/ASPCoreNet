using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test01.SqlServer
{
    public class Author
    {
        public int AuthorId { get; set; } // Primary Key
    public string Name { get; set; }
        public ICollection<Book> Books { get; set; } // Navigation Property
    }
}