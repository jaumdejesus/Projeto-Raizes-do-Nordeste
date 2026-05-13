using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.DTOs
{
    public class EstoqueUpdateDTO
    {
        [Required]
        public int IdProduto { get; set; }
        [Required]
        public int IdUnidade { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        [Column("preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}
