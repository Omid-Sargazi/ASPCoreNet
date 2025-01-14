using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagement.Application.DTOs
{
    public class BookDto
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public decimal Price {get; set;}
        public string AuthorName {get; set;}
        public string CategoryName {get; set;}
        public int InventoryQuantity {get; set;}
    }
}