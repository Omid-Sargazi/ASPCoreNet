using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ibraryManagementSystem.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}