using Dapper;
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
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DataContext _Context;

        private readonly ILogger<BookController> _logger;
        private IConfiguration config;
        private DataContext context;
        private ILogger logger;
        private TestFunctions testFunctions = new TestFunctions();


        public BookController(IConfiguration config, DataContext context, ILogger<BookController> logger)
        {
            _configuration = config;
            _logger = logger;
            _Context = context;
        }

        [HttpGet("usingDapper")]
        public async Task<ActionResult<List<Book>>> Get(int stdId)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var book = await connection.QueryAsync<Book>("SELECT * FROM Books WHERE " +
                "studentId=@studentID", new { studentId = stdId });

            if (book.IsNullOrEmpty())
            {
                _logger.LogError($"Data is not available in database for this {stdId} ID");
                return new List<Book>() { };
            }
            else
            {
                _logger.LogInformation("Executing Get method using Dapper");
                return Ok(book);
            }
        }

        // Test Function
        [HttpGet("ByOtherFunction")]
        public async Task<ActionResult<List<Book>>> GetDataByOtherFuction(string name)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var bookData = await connection.QueryAsync<Book>("SELECT * FROM Books ");
            if (bookData != null)
            {
                return Ok(testFunctions.FindByBookName(name, (List<Book>)bookData));
            }
            else
            {
                return BadRequest();
            };

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
            //var student = await _Context.Students.FindAsync(bDto.studentId);
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

    }
}
