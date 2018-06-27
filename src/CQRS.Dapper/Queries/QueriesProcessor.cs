using System;
using System.Threading.Tasks;
using CQRS.Dapper.Commands;
using CQRS.Dapper.Commands.Exceptions;
using CQRS.Dapper.Queries.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Dapper.Queries
{
    public class QueriesProcessor : IQueriesProcessor
    {
        private readonly IServiceProvider _serviceProvider;

        public QueriesProcessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<TResult> Process<TQuery, TResult>(TQuery query)
        {
            var handler = _serviceProvider.GetService<IQueryHandler<TQuery, TResult>> ();

            if (handler == null)
                throw new UnknownQueryException($"Handler for Query \"{query.GetType().Name}\" not found.");

            return handler.Execute(query);
        }
    }

    public interface IQueriesProcessor
    {
        Task<TResult> Process<TQuery, TResult>(TQuery command);
    }
}
