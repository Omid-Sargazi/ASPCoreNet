using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Review
    {
        public int ReviewId {get;set;}
        [Required]
        public string Reviewer {get; set;}
        [Range(1,5)]
        public int Rating {get; set;}
        public int BookId {get; set;}
        public Book Book {get;set;}
    }
}