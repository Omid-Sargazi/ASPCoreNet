using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.ValueObjects;

namespace BookstoreManagementSystem.Domain.Entities
{
    public class Book
    {
        public int Id {get; protected set;}
         public string Title { get; private set; }
        public Money Price { get; private set; }
        public int AuthorId { get; private set; }
        public Author Author { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }

    public Book(string title, Money price, int authorId, int categoryId)
    {
        if(string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title can not be empty");
        
        Title = title;
        Price = price ?? throw new ArgumentNullException(nameof(price));
        AuthorId = authorId;
        CategoryId = categoryId;
    }


    public void Update(string title, Money price)
    {
        if(string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.");
        Title = title;
        Price =  price ?? throw new ArgumentNullException(nameof(price));
    }


    }
}