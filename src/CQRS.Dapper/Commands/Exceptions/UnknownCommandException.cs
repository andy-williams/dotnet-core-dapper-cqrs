using System;

namespace CQRS.Dapper.Commands.Exceptions
{
    public class UnknownCommandException : Exception
    {
        public UnknownCommandException(string message) : base(message) { }
    }
}