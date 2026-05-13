using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaizesApi.Interfaces;

namespace RaizesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public EstoqueController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> AdicionarProdutoUnidade([FromBody] EstoqueUpdateDTO estoque)
        {
            var answer = await _produtoService.CadastrarProdutoUnidade(estoque);
            return answer.Success ? Ok("Produto adicionado ao estoque da unidade.") :
                BadRequest(answer.Error);             
        }
    }
}
