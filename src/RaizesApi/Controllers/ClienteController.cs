using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaizesApi.Interfaces;

namespace RaizesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
       
        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> CadastrarCliente([FromBody] ClienteDTO cliente)
        {
            var answer = await _clienteService.Cadastrar(cliente);
            return answer.Success ? Ok() : BadRequest(answer.Error);
        }

    }
}
