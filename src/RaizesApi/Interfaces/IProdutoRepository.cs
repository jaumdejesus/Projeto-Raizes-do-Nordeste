using Application.DTOs;

namespace RaizesApi.Interfaces
{
    public interface IProdutoRepository
    {
        Task<bool> Criar(Produto produto);
        Task<bool> CriarProdutoUnidade(ProdutoUnidade estoque);
        Task<List<ProdutoUnidade>> ListarProdutos(int idUnidade);
    }
}
