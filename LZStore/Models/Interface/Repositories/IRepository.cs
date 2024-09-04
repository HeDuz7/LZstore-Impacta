namespace LZStore.Models.Interface.Repositories
{
    public interface IRepository<T, Y>
    {

        void Cadastrar(T entidade);
    }
}
