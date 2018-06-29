using System.Threading.Tasks;

namespace CQRS.Dapper.Domain.Commands
{
    public interface ICommandHandler<TCommand>
    {
        Task Execute(TCommand command);
    }
}