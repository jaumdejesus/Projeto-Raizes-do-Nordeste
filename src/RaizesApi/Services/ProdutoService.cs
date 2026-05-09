using Application.DTOs;
using RaizesApi.Interfaces;

namespace RaizesApi.Services
{
    internal class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<ServiceResult> CadastrarProduto(ProdutoCreateDTO produtoDTO)
        {
            var answer = await _produtoRepository.Criar(Produto.Criar(produtoDTO));
            return answer ? ServiceResult.Ok() : 
                ServiceResult.Fail("Não foi possível cadastrar o produto.");
        }

        public List<Produto> ListarProdutos(int idUnidade)
        {
            return _produtoRepository.ListarProdutos(idUnidade).Result;
        }
    }
}
