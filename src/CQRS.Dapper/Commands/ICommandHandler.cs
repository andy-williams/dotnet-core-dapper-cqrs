using System.Threading.Tasks;

namespace CQRS.Dapper.Commands
{
    public interface ICommandHandler<TCommand>
    {
        Task Execute(TCommand command);
    }
}