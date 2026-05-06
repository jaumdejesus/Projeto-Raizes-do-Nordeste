namespace Application.DTOs
{
    public class PedidoRequestDTO
    {
        public int IdCliente { get; set; }
        public int IdUnidade { get; set; }
        public int IdCanal { get; set; }
        public List<ItemPedidoRequestDTO> Itens { get; set; } = new();
    }
}
