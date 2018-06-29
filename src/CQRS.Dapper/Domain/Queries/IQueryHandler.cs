using System.Threading.Tasks;

namespace CQRS.Dapper.Domain.Queries
{
    public interface IQueryHandler<TQuery, TResult>
    {
        Task<TResult> Execute(TQuery query);
    }
}