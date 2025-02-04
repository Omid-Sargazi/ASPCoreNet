using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQExample.Models
{
    public class BookCategory
    {
         public int BookId { get; set; } // Foreign Key
        public Book Book { get; set; } // Navigation Property
        public int CategoryId { get; set; } // Foreign Key
        public Category Category { get; set; } // Navigation Property
    }
}