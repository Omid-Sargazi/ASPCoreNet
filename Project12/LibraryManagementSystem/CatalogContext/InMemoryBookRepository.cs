using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogContext
{
    public class InMemoryBookRepository : IBookRepository
    {
        private readonly List<Book> _books = new();
        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book GetById(Guid id)
        {
            return _books.FirstOrDefault(b=>b.Id==id);
        }
    }
}