using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Entities;

namespace BookstoreManagementSystem.TestUnit.AuthorTests
{
    public class AuthorTests
    {
        [Fact]
        public void Should_Create_Valid_Author()
        {
            var name = "Author Name";

            var author = new Author(name);

            Assert.Equal(name,author.Name);
            Assert.Empty(author.Books);
        }

        [Fact]
        public void Should_Throw_Exception_When_Name_Is_Empty()
        {
            Assert.Throws<ArgumentException>(()=>new Author(""));
        }
    }
}