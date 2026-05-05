using Microsoft.AspNetCore.Mvc;
using RaizesApi.DTOs;
using RaizesApi.Interfaces;
using RaizesApi.Services;
using System.Net;

namespace RaizesApi.Controllers
{
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService _registerService;
        public RegisterController(IRegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterDTO register)
        {
            var answer = await _registerService.Register(register);
            return answer.Success ? Ok("Usuário registrado com sucesso!") : 
                BadRequest(answer.Error);
        }
    }
}
