using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreManagement.Domain.Entities
{
    public class Book
    {
       public int Id {get; private set;}
       public string Title { get; private set; }
       public decimal Price { get; private set; }
       public int AuthorId { get; private set; }
        public Author Author { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
        public Inventory Inventory { get; private set; }


        public Book(string title, decimal price, int authorId, int categoryId)
        {
            if(string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Book title cannot be empty.");
            if(price<=0)
                throw new ArgumentException("Price must be greater than zero.");

                Title = title;
                Price = price;
                AuthorId = authorId;
                CategoryId = categoryId;
        }

    }
}