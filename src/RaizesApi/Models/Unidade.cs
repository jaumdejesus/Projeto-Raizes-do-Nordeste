using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RaizesApi;

[Table("unidade")]
public class Unidade
{
    [Key]
    [Column("id_unidade")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUnidade { get; set; }

    [Required]
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [Column("endereco")]
    public string Endereco { get; set; } = string.Empty;
}
