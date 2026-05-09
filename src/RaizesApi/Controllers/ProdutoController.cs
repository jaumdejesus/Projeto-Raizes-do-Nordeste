using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaizesApi.Interfaces;

namespace RaizesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Cadastrar([FromBody]ProdutoCreateDTO produtoDTO)
        {
            var answer = await _produtoService.CadastrarProduto(produtoDTO);
            return answer.Success ? Ok() : BadRequest(answer.Error);
        }
    }
}
