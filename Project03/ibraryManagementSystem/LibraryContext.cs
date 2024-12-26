using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ibraryManagementSystem
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book> Books {get;set;}
        public DbSet<Author> Authors {get;set;}
        public DbSet<Borrower> Borrowers {get;set;}
        public DbSet<BorrowingRecord> BorrowingRecords {get;set;}
        public DbSet<Library> Libraries {get;set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("LibraryDb");
        }
    }
}