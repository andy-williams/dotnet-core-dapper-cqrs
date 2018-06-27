using System;

namespace CQRS.Dapper.Queries.Exceptions
{
    public class UnknownQueryException : Exception
    {
        public UnknownQueryException(string message) : base(message) { }
    }
}