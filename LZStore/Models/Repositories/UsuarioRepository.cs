using LZStore.Models.Contexts;
using LZStore.Models.Dtos;
using LZStore.Models.Interface.Context;
using LZStore.Models.Interface.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LZStore.Models.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly LzStoreContext _context;

        public UsuarioRepository(LzStoreContext context)
        {
            _context = context;
        }

        public void Cadastrar(UsuarioDto entidade)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioDto> Listar()
        {
            throw new NotImplementedException();
        }

        //public UsuarioDto Consultar(UsuarioDto usuario)
        //{
        //    return _contextData.EfetuarLogin(usuario);
        //}

        public UsuarioDto PesquisaLogin(string login)
        {
            return null;
            //return _context.Usuarios.FirstOrDefault(x => x.EmailCliente.Equals(login));
        }
    }
}
