namespace RaizesApi;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


[Table("status_pedido")]
public class StatusPedido
{
    [Key]
    [Column("id_status_pedido")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdStatusPedido { get; set; }

    [Required]
    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;
}
