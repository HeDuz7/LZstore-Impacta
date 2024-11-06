using LZStore.Models.Contexts;
using LZStore.Models.Dtos;
using LZStore.Models.Entidades;
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

        public void Cadastrar(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }

        public Usuario PesquisaLogin(string login)
        {
            return _context.Usuarios.FirstOrDefault(x => x.EmailCliente.Equals(login));
        }
    }
}
