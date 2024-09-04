namespace LZStore.Models.Interface.Services
{
    public interface IGenericService<T, Y>
    {
        void Cadastrar(T entidade);
    }
}
