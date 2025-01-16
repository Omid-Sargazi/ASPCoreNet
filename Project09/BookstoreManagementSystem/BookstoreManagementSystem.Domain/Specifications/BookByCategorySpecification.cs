using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Entities;

namespace BookstoreManagementSystem.Domain.Specifications
{
    public class BookByCategorySpecification
    {
        public int CategoryId {get;}

        public BookByCategorySpecification(int categoryId)
        {
            CategoryId = categoryId;
        }

        public bool IsSatisfiedBy(Book book)=>book.CategoryId == CategoryId;
    }
}