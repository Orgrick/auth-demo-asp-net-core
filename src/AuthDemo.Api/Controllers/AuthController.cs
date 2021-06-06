using Microsoft.AspNetCore.Mvc;
using AuthDemo.Domain.Interfaces;
using AuthDemo.Domain.Models;

namespace AuthDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        private readonly IAuthService _authService;

        public AuthController(IJwtService jwtService, IAuthService authService)
        {
            _jwtService = jwtService;
            _authService = authService;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] Login request)
        {
            var user = _authService.AuthenticateUser(request.Email, request.Password);

            if (user != null)
            {
                var token = _jwtService.GenerateJWT(user);

                return Ok(new { access_token = token });
            }

            return Unauthorized();
        }
    }
}
