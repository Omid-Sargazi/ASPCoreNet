using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIs.Models
{
    public class Book
    {
         public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public int GenreId { get; set; }

    // Navigation properties
    public Author Author { get; set; }
    public Genre Genre { get; set; }
    }
}