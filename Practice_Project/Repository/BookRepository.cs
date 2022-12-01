using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Practice_Project.Context;
using Practice_Project.Controllers;
using Practice_Project.Model;
using PracticeProject.Migrations;

namespace Practice_Project.Repository
{
    public class BookRepository
    {
        private readonly IConfiguration _configuration;
        private readonly DataContext _Context;
        private readonly ILogger<BookRepository> _logger;

        public BookRepository(DataContext context, ILogger<BookRepository> logger )
        {
            _Context = context;
            _logger = logger;
        }

        public async Task<ActionResult<List<Book>>> GetData(int Id)
        {
            var Books = await _Context.Books.Where(c => c.studentId == Id)
                .Include(c => c.student)
                .ToListAsync();

            if (Books.IsNullOrEmpty())
            {
                _logger.LogError($" This method is executing using Entity framework and the data is not available in database for this ID {Id}");
                return null;
            }
            else
            {
                _logger.LogInformation("Executing Get method using log");
                return Books;
            }
        }

        public async Task<ActionResult<List<Book>>> Create(BookDataTransferObject bDto)
        {
            var student = await _Context.Students.FindAsync(bDto.studentId);

            var book = new Book
            {
                Title = bDto.Title,
                student = student
            };

            _Context.Add(book);
            await _Context.SaveChangesAsync();
            return await _Context.Books.ToListAsync();
        }

    }
}
