using Microsoft.AspNetCore.Mvc;
using AuthDemo.Resource.Api.Repository;
using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using AuthDemo.Resource.Api.Models;

namespace AuthDemo.Resource.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        private Guid UserId => Guid.Parse(User.Claims.Single(c => c.Type == ClaimTypes.NameIdentifier).Value);

        public OrdersController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public IActionResult getOrders()
        {
            if (!_bookRepository.getOrders().ContainsKey(UserId))
            {
                return Ok(Enumerable.Empty<Book>());
            }

            var orderedBookIds = _bookRepository.getOrders().Single(o => o.Key == UserId).Value;
            var orderedBooks = _bookRepository.getBooks().Where(b => orderedBookIds.Contains(b.Id));

            return Ok(orderedBooks);
        }
    }
}
