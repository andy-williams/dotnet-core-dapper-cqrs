using System;
using System.Threading.Tasks;

namespace CQRS.Dapper.Domain.Commands
{
    public class DeleteBook
    {
        public int BookId { get; }

        public DeleteBook(int bookId)
        {
            BookId = bookId;
        }
    }

    public class DeleteBookHandler : ICommandHandler<DeleteBook>
    {
        public Task Execute(DeleteBook command)
        {
            throw new NotImplementedException();
        }
    }
}
