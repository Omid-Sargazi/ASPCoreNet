using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Models;

namespace Patterns.ProxyPattern.BookService
{
    public class BookService : IBookService
    {
        public Book GetBook(int id)
        {
            Console.WriteLine($"Fetching book with ID {id} from database...");
        // شبیه‌سازی داده‌های کتاب
        return new Book { Id = id, Title = "Sample Book", Author = "John Doe" };
        }
    }
}