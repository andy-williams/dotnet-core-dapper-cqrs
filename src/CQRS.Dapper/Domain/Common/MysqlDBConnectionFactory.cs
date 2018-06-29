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
            return new MySqlConnection(_connectionString);
        }
    }

    public interface IDbConnectionFactory
    {
        IDbConnection GetDbConnection();
    }
}
