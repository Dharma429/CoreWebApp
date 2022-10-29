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
        // public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TranslationViewModel> TranslationViewModel { get; set; }
        public DbSet<LanguageModel> LanguageModel { get; set; }

        public DbSet<Role> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TranslationViewModel>().HasNoKey();

            modelBuilder.Entity<LanguageModel>().HasNoKey();

           


            //Inside the ‘OnModelCreating()’ method I have specified the column types, max length and SQL types for these properties.

        }
    }
}
