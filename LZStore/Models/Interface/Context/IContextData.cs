using LZStore.Models.Dtos;

namespace LZStore.Models.Interface.Context
{
    public interface IContextData
    {
        void CadastrarCliente(ClienteDto cliente);
    }
}
