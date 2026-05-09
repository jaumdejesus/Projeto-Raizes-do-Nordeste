using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaizesApi.Interfaces;

namespace RaizesApi.Controllers
{
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IUnidadeService _unidadeService;

        public ConfigController(IUnidadeService unidadeService)
        {
            _unidadeService = unidadeService;
        }

        [HttpPost]
        [Route("adicionarUnidade")]
        public async Task<IActionResult> AdicionarUnidade([FromBody]UnidadeDTO unidadeDTO)
        {
            var answer = await _unidadeService.Criar(unidadeDTO);
            return answer.Success ? Ok() : BadRequest(answer.Error);
        }
    }
}
