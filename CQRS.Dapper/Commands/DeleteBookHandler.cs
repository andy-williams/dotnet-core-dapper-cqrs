using System;
using System.Threading.Tasks;

namespace CQRS.Dapper.Commands
{
    public class DeleteBookHandler : ICommandHandler<DeleteBook>
    {
        public Task Execute(DeleteBook command)
        {
            throw new NotImplementedException();
        }
    }
}