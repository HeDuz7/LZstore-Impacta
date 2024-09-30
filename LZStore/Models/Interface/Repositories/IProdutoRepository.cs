using LZStore.Models.Dtos;

namespace LZStore.Models.Interface.Repositories
{

    public interface IProdutoRepository : IRepository<ProdutoDto, string>
    {
        List<ProdutoDto> Listar();
    }
}
