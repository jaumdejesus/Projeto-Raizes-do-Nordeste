using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RaizesApi;

[Table("item_pedido")]
public class ItemPedido
{
    [Key]
    [Column("id_item_pedido")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdItemPedido { get; set; }

    [Column("id_pedido")]
    public int IdPedido { get; set; }

    [Column("id_produto_unidade")]
    public int IdProdutoUnidade { get; set; }

    [Column("quantidade")]
    public int Quantidade { get; set; }

    [Column("preco_unitario", TypeName = "decimal(18,2)")]
    public decimal PrecoUnitario { get; set; }
}
