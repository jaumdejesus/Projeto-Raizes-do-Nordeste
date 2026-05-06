namespace Application.DTOs
{
    public class PedidoResponseDTO
    {
        public int IdPedido { get; set; }
        public DateTime Data { get; set; }
        public string NomeCliente { get; set; } = string.Empty;
        public decimal ValorTotal { get; set; }
        public string StatusPedido { get; set; } = string.Empty;
        public string StatusPagamento { get; set; } = string.Empty;
    }
}
