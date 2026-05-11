namespace RaizesApi;

using Application.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

[Table("cliente")]
public class Cliente
{
    [Key]
    [Column("id_cliente")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdCliente { get; set; }

    [Required]
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [Column("documento")]
    public string Documento { get; set; } = string.Empty;

    [Column("data_nascimento")]
    public DateTime DataNascimento { get; set; }

    [Column("telefone")]
    public string? Telefone { get; set; }

    [Column("fidelizado")]
    public bool Fidelizado { get; set; }

    [Column("pontos_fidelidade")]
    public int PontosFidelidade { get; set; }

    public static Cliente Criar(ClienteDTO cliente)
    {
        return new Cliente()
        {
            Nome = cliente.Nome,
            Documento = cliente.Documento,
            DataNascimento = Convert.ToDateTime(cliente.DataNascimento),
            Telefone = cliente.Telefone,
            Fidelizado = cliente.Fidelizado
        };
    }
}
