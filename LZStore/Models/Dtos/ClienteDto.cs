using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static LZStore.Models.Enums.Enum;
using LZStore.Models.Entidades;

namespace LZStore.Models.Dtos
{
    [Table("tbCliente")]
    public class ClienteDto : EntidadeBase
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

        [Required(ErrorMessage = " CARGO OBRIGATORIO")]
        [Column("cargo")]
        public Cargo Cargo { get; set; }

        public ClienteDto()
        {
        }

        public ClienteDto(int idCliente, string nomeCliente, string senhaCliente, string emailCliente, int telCliente, Cargo cargo)
            : this(nomeCliente, senhaCliente, emailCliente, telCliente, cargo)
        {
            //this.Id = idCliente;
        }

        public ClienteDto(string nomeCliente, string senhaCliente, string emailCliente, int telCliente, Cargo cargo)
        {
            this.NomeCliente  = nomeCliente;
            this.SenhaCliente = senhaCliente;
            this.EmailCliente = emailCliente;
            this.TelCliente   = telCliente;
            this.Cargo        = cargo;
        }
    }
}
