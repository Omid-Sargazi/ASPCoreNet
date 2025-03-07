using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class BorrowTransaction
    {
        public int Id {get; set;}
        public DateTime BorrowDate {get; set;}
        public DateTime DueDate {get; set;}
        public DateTime? ReturnDate { get; set; }
        public decimal? FineAmount { get; set; }
        public TransactionStatus Status { get; set; }
        public string Notes { get; set; }

        public int UserId {get; set;}
        public User User {get; set;}
        public int BookId {get; set;}
        public Book Book {get; set;}

    }

    public enum TransactionStatus
    {
        Borrowed,
        Returned,
        Overdue,
        Lost
    }
}