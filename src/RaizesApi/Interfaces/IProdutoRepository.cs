using Application.DTOs;

namespace RaizesApi.Interfaces
{
    public interface IProdutoRepository
    {
        Task<bool> Criar(Produto produto);
        Task<List<Produto>> ListarProdutos(int idUnidade);
    }
}
