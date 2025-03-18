using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Models;

namespace Patterns.ProxyPattern.BookService
{
    public class BookServiceProxy : IBookService
    {
        private readonly IBookService _bookService;
        private readonly Dictionary<int, Book> _cache = new Dictionary<int, Book>();
        public BookServiceProxy(IBookService bookService)
        {
            _bookService = bookService;
        }
        public Book GetBook(int id)
        {
            if (!HasAccess())
        {
            throw new UnauthorizedAccessException("Access denied.");
        }

        // کشینگ
        if (_cache.ContainsKey(id))
        {
            Console.WriteLine($"Fetching book with ID {id} from cache...");
            return _cache[id];
        }
        var book = _bookService.GetBook(id);
        _cache[id] = book; // ذخیره در کش

        // لاگینگ
        Console.WriteLine($"Book with ID {id} fetched and cached.");

        return book;
        }

        private bool HasAccess()
    {
        // شبیه‌سازی بررسی دسترسی
        Console.WriteLine("Checking access...");
        return true; // در این مثال، همیشه دسترسی مجاز است
    }
    }
}