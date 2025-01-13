using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Infrastructure.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title)
            .IsRequired()
            .HasMaxLength(200);

            builder.Property(b => b.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

            builder.HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b=>b.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.Category)
            .WithMany(c =>c.Books)
            .HasForeignKey(b => b.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.Inventory)
            .WithOne(i => i.Book)
            .HasForeignKey<Inventory>(i => i.BookId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}