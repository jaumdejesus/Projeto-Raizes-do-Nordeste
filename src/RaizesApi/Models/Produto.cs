using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RaizesApi;

[Table("produto")]
public class Produto
{
    [Key]
    [Column("id_produto")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProduto { get; set; }

    [Column("id_categoria_produto")]
    public int IdCategoriaProduto { get; set; }

    [Required]
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;
}
