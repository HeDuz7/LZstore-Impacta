using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Repositories;

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
                var ret = _clienteRepository.PesquisaLogin(cliente.EmailCliente);
                if (ret != null) 
                { 

                }
                _clienteRepository.Cadastrar(cliente);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool EfetuarLogin(ClienteDto usuario)
        {
            try
            {
                var retorno = _clienteRepository.PesquisaLogin(usuario.EmailCliente);
                if (retorno == null)
                {
                    return false;
                    //mensagem de retorno
                }

                if (retorno.SenhaCliente != usuario.SenhaCliente)
                {
                    //mensagem de retorno
                    return false;
                }


                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

}
