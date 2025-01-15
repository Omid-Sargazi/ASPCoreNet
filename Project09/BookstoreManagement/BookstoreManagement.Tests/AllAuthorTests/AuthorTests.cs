using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Xunit;

namespace BookstoreManagement.Tests.AllAuthorTests
{
    public class AuthorTests
    {
        //[Fact]
        public void Author_ShouldBeCreated_WhenValidParametersAreProvided()
        {
            
                var name = "Test Author";
                var author = new Author(name);
                

                Assert.Equal(name, author.Name);
                Assert.Empty(author.Books);

        }

        //[Fact]
        public void Author_ShouldThrowException_WhenNameIsEmpty()
        {
            Assert.Throws<ArgumentNullException>(()=>new Author(null));
        }

        //[Fact]
        public void Author_ShouldThrowException_WhenNameIsNull()
        {
            Assert.Throws<ArgumentException>(()=>new Author(""));
        }
    }
}