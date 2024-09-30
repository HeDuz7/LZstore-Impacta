using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace LZStore.Models.Services
{
    public class ClienteService : IClienteService
    {
        private Response response;
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;

            response = new Response();
        }

        public Response Cadastrar(ClienteDto cliente)
        {
            try
            {

                var ret = _clienteRepository.PesquisaLogin(cliente.EmailCliente);
                if (ret != null) 
                {
                    response.AddError("ESSE USUÁRIO JÁ EXISTE");
                    return response;
                }

                _clienteRepository.Cadastrar(cliente);

                response.AddInfo("USUÁRIO CADASTRADO");

                return response;

                

            }
            catch (Exception ex)
            {
                
                response.AddError(ex.Message);
                return response;
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
