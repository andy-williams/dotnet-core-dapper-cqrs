using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Dapper.Commands
{
    public class CommandHandler<TCommand> : ICommandHandler<TCommand>
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandHandler(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task Execute(TCommand command)
        {
            var handler = _serviceProvider.GetService<ICommandHandler<TCommand>>();
            if (handler is CommandHandler<TCommand>)
            {
                throw new UnknownCommandException($"Handler for command \"{command.GetType().Name}\" not found.");
            }

            return handler.Execute(command);
        }
    }

    public class UnknownCommandException : Exception
    {
        public UnknownCommandException(string message) : base(message) { }
    }
}
