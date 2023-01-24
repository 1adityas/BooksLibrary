using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Models
{
    public class Books
    {
        [Key]
        public Guid  BookId { get; set; }

        public string BookName { get; set; }
        public string Author{ get; set; }
        public long TotalPages { get; set; }
        public long CurrnetPage { get; set; }   
    }
}
