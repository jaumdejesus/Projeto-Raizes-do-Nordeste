namespace RaizesApi;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("categoria_produto")]
public class CategoriaProduto
{
    [Key]
    [Column("id_categoria_produto")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCategoriaProduto { get; set; }

    [Required]
    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;
}
