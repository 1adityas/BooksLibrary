using BooksLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Repository
{
    public class BooksRepository : IBooks
    {

        private readonly BooksContext dbContext;
        public BooksRepository(BooksContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> DeleteBook(long BookId)
        {
            var Book = await dbContext.MyBooks.FindAsync(BookId);
            if (Book == null) return 0;

            dbContext.Remove(Book);
            dbContext.SaveChangesAsync();
            return 1;
        }

        public async task<Books>? GetBooks(int bookId)
        {
            var books = dbContext.MyBooks.FindAsync(bookId);
            if (books == null) return null;

            return books;
        }

        public IEnumerable<Books> GetBooks()
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertBook(Books addBook)
        {
            var book = new Books()
            {
                BookId = Guid.NewGuid(),
                Author= addBook.Author,
                BookName= addBook.BookName,
                TotalPages= addBook.TotalPages,
                CurrnetPage= addBook.CurrnetPage

            };
            await dbContext.MyBooks.AddAsync(book);
            var temp=await dbContext.SaveChangesAsync();
            return temp;
        }

        public void UpdateBook(Books book)
        {
            throw new NotImplementedException();
        }

        void IBooks.DeleteBook(long BookId)
        {
            throw new NotImplementedException();
        }

        int IBooks.InsertBook(Books book)
        {
            throw new NotImplementedException();
        }
    }
}
