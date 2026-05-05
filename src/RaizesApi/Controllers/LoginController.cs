using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaizesApi.DTOs;
using RaizesApi.Interfaces;
using RaizesApi.Services;
using System.Net;

namespace RaizesApi.Controllers
{
    [ApiController]    
    public class LoginController : ControllerBase
    {
        private readonly IToken _iTokenService;

        public LoginController(TokenService tokenService)
        {
            _iTokenService = tokenService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            return new JsonResult( new 
            { 
                token = _iTokenService.Generate(login), status = HttpStatusCode.OK 
            });
        }

        [Authorize(Roles = "admin")]
        [HttpGet]
        [Route("jogador")]
        public string Jogador() => "você é Jogador";
    }
}
