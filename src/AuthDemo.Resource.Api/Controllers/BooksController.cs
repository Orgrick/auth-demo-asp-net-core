using AuthDemo.Resource.Api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Resource.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public IActionResult getAvailableBooks()
        {
            return Ok(_bookRepository.getBooks());
        }
    }
}
