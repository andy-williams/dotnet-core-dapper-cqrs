namespace CQRS.Dapper.Commands
{
    public class DeleteBook
    {
        public int BookId { get; }

        public DeleteBook(int bookId)
        {
            BookId = bookId;
        }
    }
}
