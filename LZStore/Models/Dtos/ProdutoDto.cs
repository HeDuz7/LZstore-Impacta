using static LZStore.Models.Enums.Enum;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using LZStore.Models.Entidades;

namespace LZStore.Models.Dtos
{
    [Table("tbProduto")]
    public class ProdutoDto : EntidadeBase
    {
        [Required(ErrorMessage = " NOME DO PRODUTO OBRIGATORIO")]
        [MaxLength(255)]
        [Column("NomeProduto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = " PREÇO DO PRODUTO OBRIGATORIO")]
        [MaxLength(255)]
        [Column("PrecoProduto")]
        public string PrecoProduto { get; set; }

        [Required(ErrorMessage = " DESCRIÇÃO DO PRODUTO OBRIGATORIO")]
        [Column("DescProduto")]
        public string DescProduto { get; set; }

        [Required(ErrorMessage = " IMAGEM DO PRODUTO OBRIGATORIO")]
        [Column("IMGProduto")]
        public Int64 ImgProduto { get; set; }

        public ProdutoDto()
        {
        }

        public ProdutoDto(int idCliente, string nomeProduto, string precoProduto, string descProduto, int imgProduto)
            : this(nomeProduto, precoProduto, descProduto, imgProduto)
        {
            //this.Id = idCliente;
        }

        public ProdutoDto(string nomeProduto, string precoProduto, string descProduto, int imgProduto)
        {
            this.NomeProduto = nomeProduto;
            this.PrecoProduto = precoProduto;
            this.DescProduto = descProduto;
            this.ImgProduto = imgProduto;
        }
    }
}
