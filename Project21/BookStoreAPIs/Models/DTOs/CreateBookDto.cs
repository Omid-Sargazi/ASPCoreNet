using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPIs.Models.DTOs
{
    public class CreateBookDto
    {
        [Required]
        [MaxLength(200)]
        public string Title {get; set;}
        [MaxLength(2000)]
        public string Description {get; set;}
        [Required]
        public DateTime PublishedDate {get; set;}
        [Required]
        [Range(0.01,999.99)]
        public decimal Price {get; set;}
        [Required]
        public int AuthorId {get; set;}
        [Required]
        [RegularExpression(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$", 
            ErrorMessage = "ISBN must be a valid 10 or 13 digit number")]
        public string ISBN {get; set;}


    }
}