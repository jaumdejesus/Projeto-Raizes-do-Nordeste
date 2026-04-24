using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RaizesApi;

[Table("pedido")]
public class Pedido
{
    [Key]
    [Column("id_pedido")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdPedido { get; set; }

    [Column("id_cliente")]
    public int IdCliente { get; set; }

    [Column("id_unidade")]
    public int IdUnidade { get; set; }

    [Column("id_status_pagamento")]
    public int IdStatusPagamento { get; set; }

    [Column("id_status_pedido")]
    public int IdStatusPedido { get; set; }

    [Column("id_canal_pedido")]
    public int IdCanalPedido { get; set; }

    [Column("data")]
    public DateTime Data { get; set; }
}
