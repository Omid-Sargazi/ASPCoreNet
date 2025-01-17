using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagementSystem.Domain.Entities
{
    public class BookAddedToOrderEvent
    {
        public int OrderId {get;}
        public int BookId {get;}

        public BookAddedToOrderEvent(int orderId, int bookId)
        {
            OrderId = orderId;
            BookId = bookId;            
        }
    }
}