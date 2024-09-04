using LZStore.Models.Enums;

namespace LZStore.Models.Repositories
{
    public class SqlManager
    {
        public static string GetSql(TSql Tsql)
        {
            var sql = "";

            switch (Tsql)
            {
                //tabela cliente

                case TSql.CADASTRAR_CLIENTE:
                    sql = "insert into tabelaCliente (id, nomeCliente, emailCliente, dataNascimentoCliente, estadoCivil) values (@id, @NomeCliente, @EmailCliente, @DataNascimentoCliente, @EstadoCivil)";
                    break;

                default:
                    break;
            }

            return sql;
        }
    }
}
