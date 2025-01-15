using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Xunit;

namespace BookstoreManagement.Tests.CategoryTests
{
    public class CategoryTests
    {
        [Fact]
        public void Category_ShouldBeCreated_WhenValidParametersAreProvided()
        {
            var name = "Test Category";

            var category = new Category(name);

            Assert.Equal(name, category.Name);
            Assert.Null(category.Books);
        }
    }
}