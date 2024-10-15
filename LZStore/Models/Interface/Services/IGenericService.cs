using LZStore.Models.Dtos;
using LZStore.Models.Responses;

namespace LZStore.Models.Interface.Services
{
    public interface IGenericService<T, Y>
    {
        Response Cadastrar(T entidade);
        List<T> Listar();
    }
}
