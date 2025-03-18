using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Patterns.Models;

namespace Patterns.ProxyPattern.BookService
{
    public interface IBookService
    {
        public Book GetBook(int id);
    }
}