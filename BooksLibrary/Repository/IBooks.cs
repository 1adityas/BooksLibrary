using BooksLibrary.Models;

namespace BooksLibrary.Repository
{
    public interface IBooks
    {
        void InsertBook(Books book); // C

        IEnumerable<Books> GetBooks(); // R


        void UpdateBook(Books book); //U

        void DeleteBook(long BookId); //D
    }
}
