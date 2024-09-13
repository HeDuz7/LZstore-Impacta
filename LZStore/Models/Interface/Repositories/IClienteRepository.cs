using LZStore.Models.Dtos;
using LZStore.Models.Interface.Services;

namespace LZStore.Models.Interface.Repositories
{
    public interface IClienteRepository : IRepository<ClienteDto, string>
    {
        ClienteDto PesquisaLogin(string login);
    }
}
