using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Interfaces;

namespace BookstoreManagementSystem.Domain.Entities
{
    public class Order:IAggregateRoot
    {
        public int Id {get; private set;}
        public int CustomerId {get; private set;}
        private Customer Customer {get;  set;}
        public List<Book> Books {get; set;} = new List<Book>();
        public decimal TotalAmount => Books.Sum(b=>b.Price.Amount);

        public Order(int customerId)
        {
            if(customerId <= 0)
                throw new ArgumentException("Invalid customer ID.");
            
            CustomerId = customerId;
        }

        public void AddBook(Book book)
        {
            if(book == null)
                throw new ArgumentNullException(nameof(book));
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            if(book == null)
                throw new ArgumentNullException(nameof(book));
            Books.Remove(book);

        }

    }
}