using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Application.DTOs;

namespace RaizesApi;

[Table("produto_unidade")]
public class ProdutoUnidade
{
    [Key]
    [Column("id_produto_unidade")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdProdutoUnidade { get; set; }

    [Column("id_produto")]
    public int IdProduto { get; set; }

    [Column("id_unidade")]
    public int IdUnidade { get; set; }

    [Column("estoque")]
    public int Estoque { get; set; }

    [Column("preco", TypeName = "decimal(18,2)")]
    public decimal Preco { get; set; }

    public static ProdutoUnidade Criar(EstoqueUpdateDTO estoque)
    {
        return new ProdutoUnidade
        {
            IdProduto = estoque.IdProduto,
            IdUnidade = estoque.IdUnidade,
            Estoque = estoque.Quantidade,
            Preco = estoque.Preco
        };
    }
}
