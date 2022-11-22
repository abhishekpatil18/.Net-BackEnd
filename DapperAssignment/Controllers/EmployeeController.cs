using Dapper;
using DapperAssignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DapperAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
           private IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var emp = await connection.QueryAsync<Employee>("SELECT * FROM Employee2");
            return Ok(emp);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEmployee(Employee emp)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var newEmp = await connection.ExecuteAsync("INSERT INTO Employee2 (Name,Department,Salary)values (@Name,@Department,@Salary)", emp);
            return Ok(newEmp);
        }

        [HttpPut]
        public async Task<ActionResult> updateEmployee(Employee emp)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var updatedEmp = await connection.ExecuteAsync("Update Employee2 set Name=@Name,Department=@Department,Salary=@Salary where Id=@Id", emp);
            return Ok(updatedEmp);
        }

        [HttpDelete]
        public async Task<ActionResult> deleteEmployee(int id)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var deletedEmp = await connection.ExecuteAsync("Delete from Employee2 where Id=@Id", new { Id=id });
            return Ok(deletedEmp);
        }

    }
}
