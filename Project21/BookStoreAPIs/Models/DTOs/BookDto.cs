using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPIs.Models.DTOs
{
    public class BookDto
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public DateTime PublishedDate {get; set;}
        public decimal Price {get; set;}
        public string AuthorName {get; set;}
        public int AuthorId {get; set;}
        public string ISBN {get; set;}
        public bool IsAvailable {get; set;}
    }
}