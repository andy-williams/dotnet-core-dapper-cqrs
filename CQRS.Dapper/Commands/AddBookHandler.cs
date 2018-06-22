using System;
using System.Threading.Tasks;

namespace CQRS.Dapper.Commands
{
    public class AddBookHandler : ICommandHandler<AddBook>
    {
        public Task Execute(AddBook command)
        {
            throw new NotImplementedException();
        }
    }
}