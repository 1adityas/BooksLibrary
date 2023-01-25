using BooksLibrary.Models;

namespace BooksLibrary.Repository
{
    public interface IBooks
    {
        int InsertBook(Books book); // C

        Task<List<Books>>? GetBooks(); // R


        void UpdateBook(Books book); //U

        void DeleteBook(long BookId); //D
    }
}
