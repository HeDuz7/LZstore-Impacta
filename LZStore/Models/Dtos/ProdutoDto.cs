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
        [Column("NomeProduto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = " PREÇO DO PRODUTO OBRIGATORIO")]
        [Column("PrecoProduto")]
        public decimal PrecoProduto { get; set; }

        [Required(ErrorMessage = " DESCRIÇÃO DO PRODUTO OBRIGATORIO")]
        [Column("DescProduto")]
        public string DescProduto { get; set; }

        [Required(ErrorMessage = " IMAGEM DO PRODUTO OBRIGATORIO")]
        [Column("IMGProduto")]
        public IFormFile IMGProduto { get; set; }

        [Required(ErrorMessage = " IMAGEM DO PRODUTO OBRIGATORIO")]
        [Column("IMGProduto")]
        //public IFormFile IMGProduto { get; set; }
        public Byte[] IMGProdutoB { get; set; }

        [Required(ErrorMessage = " ESTOQUE DO PRODUTO OBRIGATORIO")]
        [Column("EstoqueProd")]
        public Int32 EstoqueProd { get; set; }

        [Required(ErrorMessage = " MODELO DO PRODUTO OBRIGATORIO")]
        [Column("ModeloProd")]
        public ModeloProd ModeloProd { get; set; }

        [Required(ErrorMessage = " TAMANHO DO PRODUTO OBRIGATORIO")]
        [Column("TamanhoProd")]
        public TamanhoProd TamanhoProd { get; set; }

        public ProdutoDto()
        {
        }

        public ProdutoDto(int idCliente, string nomeProduto, decimal precoProduto, string descProduto, IFormFile imgProduto, int estoqueProd, ModeloProd modeloProd, TamanhoProd tamanhoProd)
            : this(nomeProduto, precoProduto, descProduto, imgProduto, estoqueProd, modeloProd, tamanhoProd)
        {
            //this.Id = idCliente;
        }

        public ProdutoDto(string nomeProduto, decimal precoProduto, string descProduto, IFormFile imgProduto, int estoqueProd, ModeloProd modeloProd, TamanhoProd tamanhoProd)
        {
            this.NomeProduto = nomeProduto;
            this.PrecoProduto = precoProduto;
            this.DescProduto = descProduto;
            this.IMGProduto = imgProduto;
            this.EstoqueProd = estoqueProd;
            this.ModeloProd = modeloProd;
            this.TamanhoProd = tamanhoProd;
        }
    }
}
