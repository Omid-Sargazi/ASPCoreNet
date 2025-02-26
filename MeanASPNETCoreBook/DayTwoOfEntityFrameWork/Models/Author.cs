using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayTwoOfEntityFrameWork.Models
{
    public class Author
    {
         public int AuthorId { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}