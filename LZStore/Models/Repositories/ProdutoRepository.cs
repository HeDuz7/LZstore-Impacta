using LZStore.Models.Contexts;
using LZStore.Models.Dtos;
using LZStore.Models.Interface.Repositories;

namespace LZStore.Models.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly LzStoreContext _context;

        public ProdutoRepository(LzStoreContext context)
        {
            _context = context;
        }

        public void Cadastrar(ProdutoDto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }

        public List<ProdutoDto> Listar()
        {
            return _context.Produto.ToList();
        }
    }
}
