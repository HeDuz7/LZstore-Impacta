using LZStore.Models.Interface.Repositories;
using System.Data.SqlClient;

namespace LZStore.Models.Contexts
{
    public class ConnectionManager : IConnectionManager
    {
        private static string _connectionName = "clientes";
        private static SqlConnection connection = null;

        public ConnectionManager(IConfiguration configuration)
        {
            var connStr = configuration.GetConnectionString(_connectionName);
            if (connection == null)
            {
                connection = new SqlConnection(connStr);
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
