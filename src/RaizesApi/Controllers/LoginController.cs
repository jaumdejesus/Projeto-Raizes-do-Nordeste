using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaizesApi.DTOs;
using RaizesApi.Services;

namespace RaizesApi.Controllers
{
    [ApiController]    
    public class LoginController : ControllerBase
    {
        private readonly TokenService _tokenService;

        public LoginController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            string token = _tokenService.Gerar(login);

            return new JsonResult(new { token });
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("jogador")]
        public string Jogador() => "você é Jogador";
    }
}
