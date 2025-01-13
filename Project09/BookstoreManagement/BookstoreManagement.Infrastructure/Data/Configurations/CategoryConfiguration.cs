using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Infrastructure.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c=>c.Name)
            .IsRequired()
            .HasMaxLength(100);

            builder.HasMany(c => c.Books)
            .WithOne(b => b.Category)
            .HasForeignKey(b =>b.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}