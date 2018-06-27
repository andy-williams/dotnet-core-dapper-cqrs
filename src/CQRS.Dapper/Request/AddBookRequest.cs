namespace CQRS.Dapper.Request
{
    public class AddBookRequest
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}