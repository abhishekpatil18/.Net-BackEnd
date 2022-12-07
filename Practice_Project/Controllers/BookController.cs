using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Practice_Project.Context;
using Practice_Project.Functions;
using Practice_Project.Model;
using Practice_Project.Repository;

namespace Practice_Project.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly DataContext _Context;
        private readonly ILogger<BookController> _logger;

        public BookController(DataContext context, ILogger<BookController> logger)
        {
            _logger = logger;
            _Context = context;
        }

        [HttpGet("getAllBooks")]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            var books = await _Context.Books.ToListAsync();
            return Ok(books);
        }

        [HttpGet("getData/usingEntity")]
        public async Task<ActionResult<List<Book>>> GetByEntity(int stdID)
        {/*  
           This code is not working.
          ----------------------------

            var Id = stdID;
            var data = bReop.GetData(Id); ---->  getting error over here for Id or stdId as NullReferencePointer
            return Ok(data);

            Thats why giving Implementation over here.
            
            */

            var Books = await _Context.Books.Where(c => c.studentId == stdID)
               .ToListAsync();

            if (Books.IsNullOrEmpty())
            {
                _logger.LogError($" This method is executing using Entity framework and " +
                    $"the data is not available in database for this ID {stdID}");
                return null;
            }
            else
            {
                _logger.LogInformation("Executing Get method using entity framework log");
                return Ok(Books);
            }
        }

        [HttpPost("createBook/usingEntity")]
        public async Task<ActionResult<List<Book>>> Create(Book bDto)
        {
            var book = new Book
            {
                Title = bDto.Title,
                studentId = bDto.studentId
            };

            _Context.Add(book);
            await _Context.SaveChangesAsync();
            _logger.LogInformation("Created new record using Entity framework");
            return Ok(await _Context.Books.ToListAsync());
        }

        [HttpPut("updateBook/usingEntity")]
        public async Task<ActionResult<List<Book>>> Update(Book bDto)
        {
            var book = await _Context.Books.FirstOrDefaultAsync(x => x.bookId == bDto.bookId);
            if(book != null)
                 _Context.Entry(book).CurrentValues.SetValues(bDto);

            await _Context.SaveChangesAsync();
            _logger.LogInformation("Updated a record using Entity framework");
            return Ok(await _Context.Books.ToListAsync());
        }

        [HttpDelete("deleteBook/usingEntity")]
        public async Task<ActionResult<Book>> Delete(int id)
        {
           var book =await _Context.Books.FindAsync(id);

                _Context.Books.Remove(book);
                await _Context.SaveChangesAsync();
    
            _logger.LogInformation($"Deleted a record with Id {id} using Entity framework");
            return Ok(book);
        }


    }
}
