using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPIs.Models
{
    public class Author
    {
        public int Id {get; set;}
        [Required]
        [MaxLength(100)]
        public string Name {get; set;}
        public ICollection<Book> Books {get; set;}

    }
}