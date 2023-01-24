using BooksLibrary.Models;
using BooksLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Controllers
{
    public class BooksController
    {
        BooksContext dbContext;
        BooksRepository _repository = new BooksRepository(BooksContext: BooksContext);
        private BooksController() {
            
        }

        [HttpPost]
        public async Task<int> DeleteBook(long BookId)
        {

            var Book = await dbContext.MyBooks.FindAsync(BookId);
            if (Book == null) return 0;

            dbContext.Remove(Book);
            dbContext.SaveChangesAsync();
            return 1;
        }
    }
}
