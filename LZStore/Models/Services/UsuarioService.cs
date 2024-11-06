using LZStore.Models.Dtos;
using LZStore.Models.Entidades;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Interface.Services;
using LZStore.Models.Responses;

namespace LZStore.Models.Services
{
    public class UsuarioService : IUsuarioService
    {
        private Response response;
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;

            response = new Response();
        }

        public Response Cadastrar(UsuarioDto usuariodto)
        {
            try
            {

                var ret = _usuarioRepository.PesquisaLogin(usuariodto.EmailCliente);
                if (ret != null)
                {
                    response.AddError("ESSE USUÁRIO JÁ EXISTE");
                    return response;
                }

                Usuario usuario = new Usuario();
                usuario.Id           = usuariodto.Id;
                usuario.SenhaCliente = usuariodto.SenhaCliente;
                usuario.EmailCliente = usuariodto.EmailCliente;
                usuario.TelCliente   = usuariodto.TelCliente ;
                usuario.NomeCliente  = usuariodto.NomeCliente;
                usuario.TipoUsuario  = usuariodto.TipoUsuario;

                _usuarioRepository.Cadastrar(usuario);

                response.AddInfo("USUÁRIO CADASTRADO");

                return response;



            }
            catch (Exception ex)
            {

                response.AddError(ex.Message);
                return response;
            }
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

        public List<UsuarioDto> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
