using BooksLibrary.Repository;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Models
{
    public class BooksContext:DbContext
    {
        public BooksContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<IBooks> MyBooks { get; set; }
    }
}
