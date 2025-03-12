using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class Book
    {
        public int BookId {get; set;}
        [Required, MaxLength(100)]
        public string Title {get; set;}
        [Required, MaxLength(50)]
        public string Author {get;set;}
        [Timestamp]
        public byte[] RowVersion {get;set;}

        public List<Review> Reviews {get; set;}
        public List<Category> Categories {get; set;}

    }
}