using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPIs.Models
{
    public class Book
    {
        public int Id {get; set;}
        [Required]
        [MaxLength(200)]
        public string Title {get; set;}
        [MaxLength(2000)]
        public string Description {get; set;}
        [Required]
        public DateTime PublishedDate {get; set;}
        public decimal Price {get; set;}
        public int AuthorId {get; set;}
        public Author Author {get; set;}
        public string ISBN {get; set;}
        public bool IsAvailable {get; set;} = true;
    }
}