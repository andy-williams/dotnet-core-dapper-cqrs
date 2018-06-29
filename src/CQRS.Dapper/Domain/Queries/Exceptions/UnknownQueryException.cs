using System;

namespace CQRS.Dapper.Domain.Queries.Exceptions
{
    public class UnknownQueryException : Exception
    {
        public UnknownQueryException(string message) : base(message) { }
    }
}