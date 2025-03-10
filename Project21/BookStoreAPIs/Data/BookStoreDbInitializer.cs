using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreAPIs.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPIs.Data
{
    public static class BookStoreDbInitializer
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<BookStoreContext>();
            var logger = scope.ServiceProvider.GetRequiredService<ILogger<BookStoreContext>>();

            try
            {
                context.Database.Migrate();

                if(!context.Authors.Any())
                {
                    logger.LogInformation("Sedding database....");

                    var author1 = new Author { Name = "Robert Martin" };
                    var author2 = new Author { Name = "Martin Fowler" };
                    var author3 = new Author { Name = "Kent Beck" };
                    context.Authors.AddRange(author1, author2, author3);
                    await context.SaveChangesAsync();

                    context.Books.AddRange(
                        new Book
                        {
                            Title = "Clean Code", 
                            Description = "A handbook of agile software craftsmanship", 
                            AuthorId = author1.Id,
                            PublishedDate = new DateTime(2008, 8, 1),
                            Price = 35.99m,
                            ISBN = "978-0132350884",
                            IsAvailable = true
                        },
                         new Book 
                        { 
                            Title = "Refactoring", 
                            Description = "Improving the design of existing code", 
                            AuthorId = author2.Id,
                            PublishedDate = new DateTime(2018, 11, 20),
                            Price = 49.99m,
                            ISBN = "978-0134757599",
                            IsAvailable = true
                        },
                        new Book 
                        { 
                            Title = "Test-Driven Development", 
                            Description = "By Example", 
                            AuthorId = author3.Id,
                            PublishedDate = new DateTime(2002, 11, 18),
                            Price = 29.99m,
                            ISBN = "978-0321146533",
                            IsAvailable = true
                        }

                    );
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                
                logger.LogError(ex, "An error occurred while seeding the database.");
                throw;
            }
        }
    }
}