using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RaizesApi;

[Table("colaborador")]
public class Colaborador
{
    [Key]
    [Column("id_colaborador")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdColaborador { get; set; }

    [Column("id_unidade")]
    public int IdUnidade { get; set; }

    [Required]
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [Column("documento")]
    public string Documento { get; set; } = string.Empty;

    [Column("salario", TypeName = "decimal(18,2)")]
    public decimal Salario { get; set; }
}
