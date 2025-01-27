using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogContext
{
    public interface IBookRepository
    {
        public void AddBook(Book book);
        public Book GetById(Guid id);
            IEnumerable<Book> GetAll();
    }
}