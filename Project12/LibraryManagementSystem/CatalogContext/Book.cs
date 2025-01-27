using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogContext
{
    public class Book
    {
        public Guid Id {get; private set;}
        public string Title {get; private set;}
        public string Author {get; private set;}
        public string ISBN {get; private set;}

    public Book(string title, string author, string isbn)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

}