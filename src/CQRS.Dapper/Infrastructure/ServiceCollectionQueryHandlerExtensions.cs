using CQRS.Dapper.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Dapper.Infrastructure
{
    public static class ServiceCollectionQueryHandlerExtensions
    {
        public static void AddQueryHandler<TQueryHandler, TQuery, TResult>(this IServiceCollection @this) 
            where TQueryHandler : class, IQueryHandler<TQuery, TResult> 
            where TQuery : class
        {
            @this.AddScoped(typeof(IQueryHandler<TQuery, TResult>), typeof(TQueryHandler));
        }
    }
}