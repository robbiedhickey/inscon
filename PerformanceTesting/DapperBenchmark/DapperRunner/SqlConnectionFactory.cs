using System.Data;
using System.Data.SqlClient;

namespace DapperRunner
{
    public class SqlConnectionFactory
    {
        public static SqlConnection CreateOpenConnection(string connectionStringName)
        {
            var connection = new SqlConnection(ConfigurationHelper.GetConnectionString(connectionStringName));
            connection.Open();
            return connection;
        }

        public static SqlConnection CreateConnection(string connectionStringName)
        {
            return new SqlConnection(ConfigurationHelper.GetConnectionString(connectionStringName));
        }
    }
}