namespace RaizesApi;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("canal_pedido")]
public class CanalPedido
{
    [Key]
    [Column("id_canal_pedido")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCanalPedido { get; set; }

    [Required]
    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;
}
