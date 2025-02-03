using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqQuery.LibrarySystem
{
    public class BorrowRecord
    {
        public int BorrowId {get; set;}
        public int BookId {get; set;}
        public int StudentId {get; set;}
         public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; } // Nullable for books not yet returned
    }
}