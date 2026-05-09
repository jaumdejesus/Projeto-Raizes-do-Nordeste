using Application.DTOs;

namespace RaizesApi.Interfaces
{
    internal interface IProdutoService
    {
        /// <summary>
        /// Busca em produto_unidade o que está disponível.
        /// </summary>
        /// <param name="idUnidade"></param>
        /// <returns></returns>
        List<ProdutoUnidade> ListarPorUnidade(int idUnidade);

        /// <summary>
        /// Salva na tabela produto.
        /// </summary>
        /// <param name="produtoDTO"></param>
        void CadastrarProduto(ProdutoCreateDTO produtoDTO);
    }
}
