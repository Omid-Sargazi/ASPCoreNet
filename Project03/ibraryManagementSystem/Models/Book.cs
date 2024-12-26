using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public ICollection<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>(); 
        }
}