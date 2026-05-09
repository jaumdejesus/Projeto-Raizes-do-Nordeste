using Application.DTOs;

namespace RaizesApi.Interfaces
{
    public interface IPedidoService
    {
        void CriarPedido(PedidoRequestDTO pedidoRequestDTO);

        void AlterarStatus(int idPedido, int novoStatus);
    }
}
