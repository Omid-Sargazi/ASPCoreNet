using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BorrowingContext
{
    public class Borrowing
    {
        public Guid Id {get; private set;}
        public Guid BookId {get; private set;}
        public Guid MemberId {get; private set;}
        public DateTime BorrowDate {get; private set;}
        public DateTime DueDate {get; private set;}

        public Borrowing(Guid bookId, Guid memberId,DateTime borrowDate, DateTime dueDate)
        {
            Id = Guid.NewGuid();
            BookId = bookId;
            MemberId = memberId;
            BorrowDate = borrowDate;
            DueDate = dueDate;
        }
    }
}