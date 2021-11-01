using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Models
{
    public class CoreDBContext : DbContext
    {
        public CoreDBContext(DbContextOptions<CoreDBContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Teacher> Teacher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Inside the ‘OnModelCreating()’ method I have specified the column types, max length and SQL types for these properties.
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasColumnType("money");
                entity.Property(e => e.AddedOn)
                   .HasColumnType("date")
                   .HasDefaultValueSql("(getdate())");

            });
        }
    }
}
