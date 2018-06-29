using System.Linq;
using System.Threading.Tasks;
using CQRS.Dapper.Domain.Common;
using CQRS.Dapper.Domain.Dtos;
using Dapper;

namespace CQRS.Dapper.Domain.Queries
{
    public class GetBookById
    {
        public int BookId { get; set; }
    }

    public class GetBookByIdQueryHandler : IQueryHandler<GetBookById, Book>
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public GetBookByIdQueryHandler(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<Book> Execute(GetBookById query)
        {
            using (var conn = _dbConnectionFactory.GetDbConnection())
            {
                return await conn.QuerySingleOrDefaultAsync<Book>(@"
                    SELECT *
                    FROM Book
                    WHERE Id = @BookId
                ", query);
            }
        }
    }
}
