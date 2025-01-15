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


        public Book(string title, decimal price, int authorId, int categoryId, Author author, Category category, Inventory inventory)
        {
            if(string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Book title cannot be empty.");
            if(price<=0)
                throw new ArgumentException("Price must be greater than zero.");
            
            if(author == null)
                throw new ArgumentNullException(nameof(author));
            if(category==null)
                throw new ArgumentNullException(nameof(category));
            
            if(inventory == null)
                throw new ArgumentNullException(nameof(inventory));

                Title = title;
                Price = price;
                AuthorId = authorId;
                CategoryId = categoryId;
                Author = author;
                Category = category;
                Inventory = inventory;
        }

        public static Book Create(string title, decimal price, int authorId, int categoryId, Author author)
        {
            var book = new Book(title, price, authorId, categoryId);
             book.Author = author;
            return book;
        }
        public static Book Create<T>(string title, decimal price, int authorId, int categoryId, T relatedObject)
        {
            var book = new Book(title, price, authorId, categoryId);

            if(relatedObject is Author author)
            {
                book.Author = author;
            }
            
            if(relatedObject is Category category)
            {
                book.Category = category;
            }
             else if (relatedObject is Inventory inventory)
             {
        book.Inventory = inventory;
            }
             else
            {
                throw new ArgumentException($"Unsupported type: {typeof(T).Name}");
            }

            return book;
        }

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

        public void Update(string title, decimal price, int authorId, int categoryId)
        {
            if(string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be empty.", nameof(title));
            if(price <= 0)
                throw new ArgumentException("Price must be greater than zero.", nameof(price));
            Title = title;
            Price = price;
            AuthorId = authorId;
            CategoryId = categoryId;

        }

    }
}