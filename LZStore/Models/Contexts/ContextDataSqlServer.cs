using LZStore.Models.Dtos;
using LZStore.Models.Enums;
using LZStore.Models.Interface.Context;
using LZStore.Models.Interface.Repositories;
using LZStore.Models.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace LZStore.Models.Contexts
{
    public class ContextDataSqlServer : IContextData
    {
        private readonly SqlConnection _connection = null;

        public ContextDataSqlServer(IConnectionManager connectioManager)
        {
            _connection = connectioManager.GetConnection();
        }

        public void CadastrarCliente(ClienteDto cliente)
        {
            try
            {
                _connection.Open();
                var query = SqlManager.GetSql(TSql.CADASTRAR_CLIENTE);

                var command = new SqlCommand(query, _connection);

                command.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.Id;
                command.Parameters.Add("@nome", SqlDbType.VarChar).Value = cliente.NomeCliente;
                command.Parameters.Add("@senha", SqlDbType.VarChar).Value = cliente.SenhaCliente;
                command.Parameters.Add("@emailCliente", SqlDbType.VarChar).Value = cliente.EmailCliente;
                command.Parameters.Add("@telefone", SqlDbType.DateTime).Value = cliente.TelCliente;
                command.Parameters.Add("@cargo", SqlDbType.Int).Value = cliente.Cargo;

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
    }
}
