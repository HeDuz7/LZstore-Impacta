using LZStore.Models.Dtos;

namespace LZStore.Models.Interface.Services
{
    public interface IClienteService : IGenericService<ClienteDto, string>
    {
        bool EfetuarLogin(ClienteDto usuario);
    }
}
