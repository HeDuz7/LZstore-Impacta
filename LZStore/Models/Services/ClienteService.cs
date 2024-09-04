using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;

namespace LZStore.Models.Services
{
    public class ClienteService : IClienteService
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Cadastrar(ClienteDto cliente)
        {
            try
            {
                _clienteRepository.Cadastrar(cliente);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
