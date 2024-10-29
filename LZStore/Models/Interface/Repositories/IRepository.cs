using LZStore.Models.Entidades;

namespace LZStore.Models.Interface.Repositories
{
    public interface IRepository<T, Y>
    {
        void Cadastrar(T entidade);
        List<T> Listar();

    }
}
