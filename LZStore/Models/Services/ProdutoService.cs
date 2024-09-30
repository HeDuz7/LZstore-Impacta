
using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;

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

        public Response Cadastrar(ProdutoDto produto)
        {

            try
            {
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
                return _produtoRepository.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
