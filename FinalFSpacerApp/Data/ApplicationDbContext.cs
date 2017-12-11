using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinalFSpacerApp.Models;

namespace FinalFSpacerApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<DriveCard>().ToTable("DriveCard");
            builder.Entity<SpacerCard>().ToTable("SpacerCard");
            builder.Entity<Operator>().ToTable("Operator");
        }

        public DbSet<FinalFSpacerApp.Models.DriveCard> DriveCards { get; set; }
        public DbSet<FinalFSpacerApp.Models.SpacerCard> SpacerCards { get; set; }
        public DbSet<FinalFSpacerApp.Models.Operator> Operators { get; set; }
    }
}
