using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonSaze.Domains.Domain.FinancialCredit;
using BonSaze.Domains.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BonSaze.Infrastructures.CommandDB
{
    public class BonSazeBaseCommandDb:IdentityDbContext<ApplicantUser, ApplicantRole,Guid>
    {
        public BonSazeBaseCommandDb(DbContextOptions<BonSazeBaseCommandDb> options):base(options){}

        public DbSet<CreditRating> CreditRatings {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<ApplicantUser>(entity =>
        {
            entity.ToTable("Users"); // Rename IdentityUser table
            entity.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            entity.Property(u => u.LastName).IsRequired().HasMaxLength(50);
        });

        // Configure ApplicantRole
        modelBuilder.Entity<ApplicantRole>(entity =>
        {
            entity.ToTable("Roles"); // Rename IdentityRole table
            entity.Property(r => r.Description).HasMaxLength(200);
        });
        }
    }
}