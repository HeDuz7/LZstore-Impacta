using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;

namespace LZStore.Models.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Cadastrar(UsuarioDto entidade)
        {
            throw new NotImplementedException();
        }

        public bool EfetuarLogin(UsuarioDto usuario)
        {
            try
            {
                var retorno = _usuarioRepository.PesquisaLogin(usuario.EmailCliente);
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
