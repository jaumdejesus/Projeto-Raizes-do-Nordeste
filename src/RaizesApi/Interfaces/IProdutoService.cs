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
        public List<ProdutoUnidade> ListarProdutosPorUnidade(int idUnidade);

        /// <summary>
        /// Salva na tabela produto.
        /// </summary>
        /// <param name="produtoDTO"></param>
        Task<ServiceResult> CadastrarProduto(ProdutoCreateDTO produtoDTO);

        /// <summary>
        /// Salva na tabela produto_unidade, associando o produto a uma unidade e informando o estoque e preço.
        /// </summary>
        /// <param name="estoque"></param>
        /// <returns></returns>
        Task<ServiceResult> CadastrarProdutoUnidade(EstoqueUpdateDTO estoque);
    }
}
