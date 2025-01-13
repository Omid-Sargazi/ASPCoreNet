using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Infrastructure.Data.Configurations
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Quantity).IsRequired();

            builder.HasOne(i => i.Book)
            .WithOne(b =>b.Inventory)
            .HasForeignKey<Inventory>(i=>i.BookId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}