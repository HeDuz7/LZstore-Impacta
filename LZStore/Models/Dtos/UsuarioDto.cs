using LZStore.Models.Entidades;
using static LZStore.Models.Enums.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LZStore.Models.Dtos
{
    [Table("tbCliente")]
    public class UsuarioDto : EntidadeBase
    {

        [Required(ErrorMessage = " NOME DO CLIENTE OBRIGATORIO")]
        [MaxLength(255)]
        [Column("nome")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = " SENHA DO CLIENTE OBRIGATORIO")]
        [MaxLength(255)]
        [Column("senha")]
        public string SenhaCliente { get; set; }

        [Required(ErrorMessage = " EMAIL OBRIGATORIO")]
        [EmailAddress(ErrorMessage = "EMAIL INVALIDO")]
        [Column("email")]
        public string EmailCliente { get; set; }

        [Required(ErrorMessage = " TELEFONE OBRIGATORIO")]
        [Column("telefone")]
        public Int64 TelCliente { get; set; }

        [Required(ErrorMessage = " TIPO USUARIO OBRIGATORIO")]
        [Column("tipoUsuario")]
        public TipoUsuario TipoUsuario { get; set; }

        public UsuarioDto()
        {
        }

            public UsuarioDto(int idCliente, string nomeCliente, string senhaCliente, string emailCliente, int telCliente, TipoUsuario tipoUsuario)
            : this(nomeCliente, senhaCliente, emailCliente, telCliente, tipoUsuario)
            {
                //this.Id = idCliente;
            }

            public UsuarioDto(string nomeCliente, string senhaCliente, string emailCliente, int telCliente, TipoUsuario tipoUsuario)
            {
                this.NomeCliente = nomeCliente;
                this.SenhaCliente = senhaCliente;
                this.EmailCliente = emailCliente;
                this.TelCliente = telCliente;
                this.TipoUsuario = tipoUsuario;
            }   
        
    }
}
