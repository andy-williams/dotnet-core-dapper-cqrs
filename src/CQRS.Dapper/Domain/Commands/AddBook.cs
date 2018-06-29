using System;
using System.Threading.Tasks;

namespace CQRS.Dapper.Domain.Commands
{
    public class AddBook
    {
        public string Author { get; }
        public string Title { get; }

        public AddBook(string author, string title)
        {
            Author = author;
            Title = title;
        }
    }

    public class AddBookHandler : ICommandHandler<AddBook>
    {
        public Task Execute(AddBook command)
        {
            throw new NotImplementedException();
        }
    }
}