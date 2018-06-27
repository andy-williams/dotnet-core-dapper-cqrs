using CQRS.Dapper.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Dapper.Infrastructure
{
    public static class ServiceCollectionCommandHandlerExtensions
    {
        public static void AddCommandHandler<TCommandHandler, TCommand>(this IServiceCollection @this) 
            where TCommandHandler : class, ICommandHandler<TCommand>
            where TCommand : class
        {
            @this.AddScoped(typeof(ICommandHandler<TCommand>), typeof(TCommandHandler));
        }
    }
}