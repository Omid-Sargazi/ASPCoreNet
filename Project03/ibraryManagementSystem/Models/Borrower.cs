using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ibraryManagementSystem.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<BorrowingRecord> BorrowingRecords { get; set; } = new List<BorrowingRecord>();
    
    }
}