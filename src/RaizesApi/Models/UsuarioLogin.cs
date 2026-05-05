using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RaizesApi.DTOs;

namespace RaizesApi.Models
{
    [Table("usuario_login")]
    public class UsuarioLogin
    {
        [Key]
        [Column("id_usuario_login")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuarioLogin { get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Column("senha_hash")]
        public string SenhaHash { get; set; } = string.Empty;

        [Required]
        [Column("document")]
        public string Document { get; set; } = string.Empty;

        [Column("criado_em")]
        public DateTime CriadoEm { get; set; }

        // Chave estrangeira para Cliente
        [Column("id_cliente")]
        public int? IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente? Cliente { get; set; } = null!;

        public static UsuarioLogin Create(RegisterDTO register)
        {
            return new UsuarioLogin
            {
                Email = register.Email,
                SenhaHash = BCrypt.Net.BCrypt.HashPassword(register.Password),
                CriadoEm = DateTime.UtcNow,
                Document = register.Document
            };
        }
    }
}
