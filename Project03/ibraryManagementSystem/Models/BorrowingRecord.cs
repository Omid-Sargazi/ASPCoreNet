using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ibraryManagementSystem.Models
{
    public class BorrowingRecord
    {
       public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
        public DateTime BorrowedDate { get; set; } 
    }
}