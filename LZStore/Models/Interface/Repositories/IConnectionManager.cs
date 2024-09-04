using System.Data.SqlClient;

namespace LZStore.Models.Interface.Repositories
{
    public interface IConnectionManager
    {
        SqlConnection GetConnection();
    }
}
