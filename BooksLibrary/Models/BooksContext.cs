using BooksLibrary.Repository;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Models
{
    public class BooksContext:DbContext
    {
        public BooksContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Books> MyBooks { get; set; }
        public DbSet<User> User { get; set; }
    }
}
