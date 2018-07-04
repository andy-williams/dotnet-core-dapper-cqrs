using System;
using System.Threading.Tasks;
using CQRS.Dapper.Domain.Commands;
using CQRS.Dapper.Domain.Queries;
using CQRS.Dapper.Request;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Dapper.Controllers
{
    [Route("")]
    public class BooksController : Controller
    {
        private readonly ICommandsProcessor _commandProcessor;
        private readonly IQueriesProcessor _queriesProcessor;

        public BooksController(ICommandsProcessor commandProcessor, IQueriesProcessor queriesProcessor)
        {
            _commandProcessor = commandProcessor;
            _queriesProcessor = queriesProcessor;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{bookId:int}")]
        public async Task<IActionResult> GetBook(int bookId)
        {
            throw new NotImplementedException();
        }


        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] AddBookRequest addBookRequest)
        {
            await _commandProcessor.Process(new AddBook(addBookRequest.Author, addBookRequest.Title));
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{bookId:int}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
