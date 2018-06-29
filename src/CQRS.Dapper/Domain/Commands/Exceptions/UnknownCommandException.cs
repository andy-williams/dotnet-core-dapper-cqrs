using System;

namespace CQRS.Dapper.Domain.Commands.Exceptions
{
    public class UnknownCommandException : Exception
    {
        public UnknownCommandException(string message) : base(message) { }
    }
}