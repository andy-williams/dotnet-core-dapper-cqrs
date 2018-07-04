using System.Data;
using MySql.Data.MySqlClient;

namespace CQRS.Dapper.Domain.Common
{
    public class MysqlDbConnectionFactory : IDbConnectionFactory
    {
        private readonly string _connectionString;

        public MysqlDbConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetDbConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }

    public interface IDbConnectionFactory
    {
        IDbConnection GetDbConnection();
    }
}
