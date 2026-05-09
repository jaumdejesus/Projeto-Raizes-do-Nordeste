using Application.DTOs;
using System.Reflection;

namespace RaizesApi.Interfaces
{
    public interface IEstoqueService
    {
        /// <summary>
        /// Gerencia a tabela produto_unidade.
        /// </summary>
        /// <param name="estoqueUpdateDTO"></param>
        void AtualizarEstoquePreco(EstoqueUpdateDTO estoqueUpdateDTO);

        /// <summary>
        /// Método interno para checar se há saldo antes de vender.
        /// </summary>
        /// <param name="idProdutoUnidade"></param>
        /// <param name="qtd"></param>
        /// <returns></returns>
        bool ValidarDisponibilidade(int idProdutoUnidade, int qtd);
    }
}
