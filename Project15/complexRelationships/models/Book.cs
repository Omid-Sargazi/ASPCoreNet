using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace complexRelationships.models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; } // Foreign Key
        public Author Author { get; set; } // Navigation Property
        public List<BookCategory> BookCategories { get; set; } = new List<BookCategory>(); //// Many-to-Many
    }
}