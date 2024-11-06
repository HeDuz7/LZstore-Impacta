using LZStore.Models.Dtos;
using LZStore.Models.Entidades;

namespace LZStore.Models.Interface.Repositories
{

    public interface IProdutoRepository : IRepository<Produto, string>
    {
        Produto PesquisaPorId(int id);
    }
}
