using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RaizesApi;

[Table("status_pagamento")]
public class StatusPagamento
{
    [Key]
    [Column("id_status_pagamento")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdStatusPagamento { get; set; }

    [Required]
    [Column("descricao")]
    public string Descricao { get; set; } = string.Empty;
}
