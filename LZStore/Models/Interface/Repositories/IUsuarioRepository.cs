using LZStore.Models.Dtos;

namespace LZStore.Models.Interface.Repositories
{
    public interface IUsuarioRepository : IRepository<UsuarioDto, int>
    {
        //UsuarioDto EfetuarLogin(UsuarioDto usuario);
        UsuarioDto PesquisaLogin(string login);
    }
}
