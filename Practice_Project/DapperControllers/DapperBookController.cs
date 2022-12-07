using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Practice_Project.Functions;
using Practice_Project.Model;
using System.Data;

namespace Practice_Project.DapperControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DapperBookController : ControllerBase
    {
        private IConfiguration _configuration;
        private ILogger<DapperBookController> _logger;
        private BooksTestFunctions testFunctions = new BooksTestFunctions();


        public DapperBookController(IConfiguration config, ILogger<DapperBookController> logger)
        {
            _configuration = config;
            _logger = logger;
        }


        [HttpGet("GetAllBooksBySP")]
        public async Task<ActionResult<List<Book>>> GetAllBooksBySP()
        {
            using var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var books = await conn.QueryAsync<Book>("SP_GetBooks");
            return Ok(books);
        }

        [HttpGet("GetBookByID")]
        public async Task<ActionResult<List<Book>>> GetBookById( int Id )
        {
            using var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var book = await conn.QueryAsync<Book>("GetBookByID", new { bookId = Id }, commandType:CommandType.StoredProcedure);
            return Ok(book);
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

        //Getting data by Join Query.. using 1:1 relationship
        [HttpGet("usingTablesRelation")]
        public async Task<ActionResult<List<object>>> GetDataByJoins()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var book = await connection.QueryAsync<object>("SELECT Students.Id ,Students.Name , Students.Department , Books.Title as BookName\r\nfrom Books inner Join Students on Books.studentId = Students.Id");

            return Ok(book);
        }

        // Test Function
        [HttpGet("byTestFuction")]
        public async Task<ActionResult<List<Book>>> GetDataByTestFuction(string name)
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

        //Updating Book Details
        [HttpPut("UpdateBooksBySP")]
        public async Task<ActionResult<List<Book>>> UpdateBooksBySP(Book b)
        {
            using var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var book = await conn.ExecuteAsync("UpdateBook", new {bookId=b.bookId,Title=b.Title,studentID=b.studentId},commandType:CommandType.StoredProcedure);
            return Ok(book);
        }


        //Deleting Book
        [HttpDelete("deleteBook")]
        public async Task<ActionResult<List<Book>>> DeleteBook(int id)
        {
            using var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var book = await conn.ExecuteAsync("Delete_Book", new { Id = id },commandType: CommandType.StoredProcedure);
            return Ok(book);
        }

    }
}
