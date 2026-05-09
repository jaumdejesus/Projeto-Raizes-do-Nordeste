using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Application.DTOs;

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

    public static Produto Criar(ProdutoCreateDTO produto)
    {
        return new Produto
        {
            IdCategoriaProduto = produto.IdCategoria,
            Nome = produto.Nome
        };
    }
}
