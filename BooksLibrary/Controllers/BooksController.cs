using BooksLibrary.Models;
using BooksLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //here [controller] will return employee name

    public class BooksController: Controller
    {
        private readonly BooksContext dbContext;
        private BooksRepository _repository;
        public BooksController(BooksContext dbContext) {
            this.dbContext = dbContext;
            this._repository = new BooksRepository(dbContext);

        }



        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var result = await _repository.GetBooks();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> InsertBook(Books addBook)
        {
            var result = await _repository.InsertBook(addBook);
            return Ok(result);
        }
        [HttpDelete]
        [Route("{bookId:guid}")]
        public async Task<IActionResult> DeleteBook([FromRoute] Guid bookId)
        {
            var result = await _repository.DeleteBook(bookId);
            return Ok(result);
        }
            
    }
}
