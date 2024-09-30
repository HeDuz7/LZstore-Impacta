using LZStore.Models.Dtos;

namespace LZStore.Models.Interface.Services
{

    public interface IProdutoService : IGenericService<ProdutoDto, string>
    {
        List<ProdutoDto> Listar();
    }
}
