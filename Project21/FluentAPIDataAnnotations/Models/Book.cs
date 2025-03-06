using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FluentAPIDataAnnotations.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Column("BookTitle")]
        [StringLength(100)]
        [Required]
        // [Index(nameof(Title))]
        public string Title { get; set; }
        public string Author {get; set;}
    }
}