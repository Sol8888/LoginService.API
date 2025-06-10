using LoginService.API.Application.Services;
using LoginService.API.API.Models;
using Microsoft.AspNetCore.Mvc;
using LoginService.API.Domain.Interfaces;



namespace LoginService.API.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _authService.ValidateLogin(request.Username, request.Password);
            if (user == null) return Unauthorized("Credenciales inválidas");

            return Ok(new { message = "Login exitoso", username = user.Username });
        }

    }
}
