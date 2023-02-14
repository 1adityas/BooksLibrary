//using BooksLibrary.Models;
//using BooksLibrary.Repository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System.Formats.Asn1;

//namespace BooksLibrary.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {

//        private readonly BooksContext _authContext;
//        //private BooksRepository _repository;
//        public UserController(BooksContext dbContext)
//        {
//            this._authContext = dbContext;

//        }
//        [HttpPost("authenticate")]
//        public async Task<IActionResult> Authenticate([FromBody] User userObj)
//        {
//            if (userObj == null)
//            {
//                return BadRequest();
//            }
//            var user = await _authContext.User.FirstOrDefault(x=> x.UserName==userObj.UserName && );
//        }
//    }
//}
