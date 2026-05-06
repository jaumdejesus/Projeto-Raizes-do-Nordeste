namespace Application.DTOs
{
    public class EstoqueUpdateDTO
    {
        public int IdProduto { get; set; }
        public int IdUnidade { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
