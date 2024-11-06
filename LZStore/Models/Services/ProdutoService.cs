
using LZStore.Models.Dtos;
using LZStore.Models.Entidades;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;
using Microsoft.AspNetCore.Http;
using System.Collections;
using System.IO;

namespace LZStore.Models.Services
{
    public class ProdutoService : IProdutoService
    {
        private Response response;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;

            response = new Response();
        }

        private byte[] ConvertGetBytes(IFormFile formFile)
        {
            using var memoryStream = new MemoryStream();
            formFile.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }


        
        private IFormFile ToIFormFile(byte[] fileBytes, string fileName)
        {
            var memoryStream = new MemoryStream(fileBytes);
            var formFile = new FormFile(memoryStream, 0, fileBytes.Length, null,  fileName);
            formFile.Headers = new HeaderDictionary();
            formFile.ContentType = "application/octet-stream";
            formFile.ContentDisposition = $"filename=\"{fileName}\"";

            return formFile;
        }
        

        public Response Cadastrar(ProdutoDto produtodto)
        {
            try
            {
                Produto produto = new Produto();
                produto.Id           = produtodto.Id;
                produto.TamanhoProd  = produtodto.TamanhoProd;
                produto.NomeProduto  = produtodto.NomeProduto;
                produto.PrecoProduto = produtodto.PrecoProduto;
                produto.DescProduto  = produtodto.DescProduto;
                produto.EstoqueProd  = produtodto.EstoqueProd;
                produto.ModeloProd   = produtodto.ModeloProd;

                var ImageBytes = ConvertGetBytes(produtodto.IMGProduto);

                produto.IMGProduto = ImageBytes;


                _produtoRepository.Cadastrar(produto);

                response.AddInfo("PRODUTO CADASTRADO");

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return response;

        }

        public List<ProdutoDto> Listar()
        {
            try
            {
                var list = _produtoRepository.Listar();
                IList<ProdutoDto> retorno = new List<ProdutoDto>();
                
                foreach(var item in list)
                {

                    retorno.Add(new ProdutoDto()
                    {
                        Id = item.Id,
                        TamanhoProd = item.TamanhoProd,
                        NomeProduto = item.NomeProduto,
                        PrecoProduto = item.PrecoProduto,
                        DescProduto = item.DescProduto,
                        EstoqueProd = item.EstoqueProd,
                        ModeloProd = item.ModeloProd,
                        IMGProdutoB = item.IMGProduto
                    });

                    
                }

                return retorno.ToList<ProdutoDto>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProdutoDto PesquisaPorId(int id)
        {
            try
            {
                var produto = _produtoRepository.PesquisaPorId(id);

                ProdutoDto Dto = new ProdutoDto();
                Dto.Id           = produto.Id;
                Dto.TamanhoProd  = produto.TamanhoProd;
                Dto.NomeProduto  = produto.NomeProduto;
                Dto.PrecoProduto = produto.PrecoProduto;
                Dto.DescProduto  = produto.DescProduto;
                Dto.EstoqueProd  = produto.EstoqueProd;
                Dto.ModeloProd   = produto.ModeloProd;
                Dto.IMGProdutoB  = produto.IMGProduto;

                return Dto;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
