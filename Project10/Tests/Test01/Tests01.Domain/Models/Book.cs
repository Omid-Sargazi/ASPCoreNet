using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests01.Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}