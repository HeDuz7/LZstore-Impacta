using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static LZStore.Models.Enums.Enum;

namespace LZStore.Models.Entidades
{
    [Table("tbCliente")]
    public class Usuario : EntidadeBase
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

        public Usuario()
        {
        }

        public Usuario(int idCliente, string nomeCliente, string senhaCliente, string emailCliente, int telCliente, TipoUsuario tipoUsuario)
            : this(nomeCliente, senhaCliente, emailCliente, telCliente, tipoUsuario)
        {
            //this.Id = idCliente;
        }

        public Usuario(string nomeCliente, string senhaCliente, string emailCliente, int telCliente, TipoUsuario tipoUsuario)
        {
            this.NomeCliente = nomeCliente;
            this.SenhaCliente = senhaCliente;
            this.EmailCliente = emailCliente;
            this.TelCliente = telCliente;
            this.TipoUsuario = tipoUsuario;
        }

    }
}
