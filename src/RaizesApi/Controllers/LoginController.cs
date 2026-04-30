using Microsoft.AspNetCore.Mvc;
using RaizesApi.DTOs;
using RaizesApi.Services;

namespace RaizesApi.Controllers
{
    [ApiController]    
    public class LoginController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDto login)
        {
            string token = new TokenService().Gerar(login);

            return new JsonResult(new { token });
        }
    }
}
