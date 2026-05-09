using Application.DTOs;
using RaizesApi.Services;

namespace RaizesApi.Interfaces
{
    public interface IProdutoService
    {
        /// <summary>
        /// Busca em produto_unidade o que está disponível.
        /// </summary>
        /// <param name="idUnidade"></param>
        /// <returns></returns>
        List<Produto> ListarProdutos(int idUnidade);

        /// <summary>
        /// Salva na tabela produto.
        /// </summary>
        /// <param name="produtoDTO"></param>
        Task<ServiceResult> CadastrarProduto(ProdutoCreateDTO produtoDTO);
    }
}
