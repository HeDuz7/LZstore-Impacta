using LZStore.Models.Dtos;
using LZStore.Models.Entidades;

namespace LZStore.Models.Interface.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, int>
    {
        Usuario PesquisaLogin(string login);
    }
}
