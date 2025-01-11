using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test01.SqlServer
{
    public class Book
    {
         public int BookId { get; set; } // Primary Key
        public string Title { get; set; }
        public int AuthorId { get; set; } // Foreign Key
        public Author Author { get; set; } // Navigation Property
    }
}