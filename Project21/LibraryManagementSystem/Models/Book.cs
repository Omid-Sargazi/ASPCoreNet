using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
       public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public int CopiesAvailable { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public byte[] CoverImage { get; set; }
        public byte[] RowVersion { get; set; } // For concurrency control

        public ICollection<Review> Reviews {get; set;}
        public ICollection<BookCategory> BookCategories {get; set;}
        public ICollection<BorrowTransaction> borrowTransactions {get; set;}
         
    }
}