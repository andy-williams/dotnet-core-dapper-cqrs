using System.Threading.Tasks;

namespace CQRS.Dapper.Queries
{
    public interface IQueryHandler<TQuery, TResult>
    {
        Task<TResult> Execute(TQuery query);
    }
}