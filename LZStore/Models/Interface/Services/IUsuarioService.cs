using LZStore.Models.Dtos;

namespace LZStore.Models.Interface.Services
{
    public interface IUsuarioService : IGenericService<UsuarioDto, int>
    {
        bool EfetuarLogin(UsuarioDto usuario);
    }
}
