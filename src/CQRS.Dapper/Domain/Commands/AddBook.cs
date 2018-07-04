using System;
using System.Threading.Tasks;
using CQRS.Dapper.Domain.Common;
using Dapper;

namespace CQRS.Dapper.Domain.Commands
{
    public class AddBook
    {
        public string Author { get; }
        public string Title { get; }

        public AddBook(string author, string title)
        {
            Author = author;
            Title = title;
        }
    }

    public class AddBookHandler : ICommandHandler<AddBook>
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public AddBookHandler(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task Execute(AddBook command)
        {
            using (var conn = _connectionFactory.GetDbConnection())
            {
                await conn.ExecuteAsync(@"
                    INSERT INTO Book (Title, Author) 
                    VALUES (@Title, @Author);
                ", command);
            }
        }
    }
}