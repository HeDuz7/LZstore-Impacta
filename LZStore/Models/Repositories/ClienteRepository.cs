using LZStore.Models.Contexts;
using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;

namespace LZStore.Models.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LzStoreContext _context;

        public ClienteRepository(LzStoreContext context)
        {
            _context = context;
        }

        public void Cadastrar(ClienteDto cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public ClienteDto PesquisaLogin(string login)
        {
            return _context.Clientes.FirstOrDefault(x => x.EmailCliente.Equals(login));
        }
    }
}
