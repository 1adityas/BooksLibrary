namespace BooksLibrary.Models
{
    public class Books
    {
        public Guid  BookId { get; set; }

        public string BookName { get; set; }
        public string Author{ get; set; }
        public long TotalPages { get; set; }
        public long CurrnetPage { get; set; }
    }
}
