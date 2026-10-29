
using Microsoft.EntityFrameworkCore;
using BookStoreEFCore.Models;

namespace BookStoreEFCore.Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;
                  Database=ReadMoreBooksDB;
                  Trusted_Connection=True;
                  TrustServerCertificate=True");
        }
    }
}
