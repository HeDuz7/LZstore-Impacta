using LZStore.Models.Entidades;
using static LZStore.Models.Enums.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LZStore.Models.Dtos
{
    [Table("tbCliente")]
    public class UsuarioDto : EntidadeBase
    {

            [Required(ErrorMessage = " SENHA DO CLIENTE OBRIGATORIO")]
            [MaxLength(255)]
            [Column("senha")]
            public string SenhaCliente { get; set; }

            [Required(ErrorMessage = " EMAIL OBRIGATORIO")]
            [EmailAddress(ErrorMessage = "EMAIL INVALIDO")]
            [Column("email")]
            public string EmailCliente { get; set; }

            public UsuarioDto()
            {
            }

            public UsuarioDto(int idCliente, string senhaCliente, string emailCliente)
                : this(senhaCliente, emailCliente)
            {
                //this.Id = idCliente;
            }

            public UsuarioDto( string senhaCliente, string emailCliente)
            {
                this.SenhaCliente = senhaCliente;
                this.EmailCliente = emailCliente;
            }
        
    }
}
