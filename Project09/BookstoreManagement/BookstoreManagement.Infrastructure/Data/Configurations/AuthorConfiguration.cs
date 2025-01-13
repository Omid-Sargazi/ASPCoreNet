using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Infrastructure.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a =>a.Id);

            builder.Property(a =>a.Name)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasMany(a => a.Books)
            .WithOne(b =>b.Author)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Navigation(a =>a.Books).AutoInclude();
        }
    }
}