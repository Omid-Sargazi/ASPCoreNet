using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Tests01.Domain.Interfaces;
using Tests01.Domain.Models;
using Tests01.WebApi.Controllers;

namespace Tests01.UnitTest.Tests
{
    public class AuthorsControllerWithRepositoryTests
    {
        private readonly Mock<IRepository<Author>> _mockRepository;
        private readonly AuthorsController _controller;

        public AuthorsControllerWithRepositoryTests()
        {
            _mockRepository = new Mock<IRepository<Author>>();
            _controller = new AuthorsController(_mockRepository.Object);
        }


        //[Fact]
        public async Task GetAllAuthors_ShouldReturnAllAuthors()
        {
            var authors = new List<Author> 
            {
                new Author { Id = 1, Name = "Author 1" },
                new Author { Id = 2, Name = "Author 2" }
            };

            _mockRepository.Setup(repo => repo.GetAllAsync()).ReturnsAsync(authors);

            //Act
            var result = await _controller.GetAllAuthors();

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnedAuthors = Assert.IsType<List<Author>>(okResult.Value);
            // Assert.Equal(2, returnedAuthors.Count);
            Assert.Equal("Author 1", returnedAuthors[0].Name);
        }

        public async Task GetAuthorById_ExistingId_ShouldReturnAuthor()
        {
            var author = new Author {Id=1, Name="Author 1"};

            var result = _mockRepository.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(author);

            //Act
            var okResult = Assert.IsType<ObjectResult>(result);
            var returnedAuthor = Assert.IsType<Author>(okResult.Value);
            Assert.Equal(1, returnedAuthor.Id);
        }
    }
}