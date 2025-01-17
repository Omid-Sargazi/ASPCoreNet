using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagementSystem.Domain.Entities;

namespace BookstoreManagementSystem.TestUnit.CategoryTests
{
    public class CategoryTests
    {
        [Fact]
        public void Should_Create_Valid_Category()
        {
            var name = "Category Test";

            var Category = new Category(name);

            Assert.Equal(name, Category.Name);
            Assert.Empty(Category.Books);
        }

        public void Should_Throw_Exception_When_Name_Is_Empty()
        {
            Assert.Throws<ArgumentException>(()=>new Category(""));
        }
    }
}