using Ado.NetApp.Models;
using Ado.NetApp.Repositorys;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Ado.NetApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IConfiguration _configuration;

        private EmployeeRepository empReop;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
            empReop = new EmployeeRepository(configuration);
        }

        [HttpGet("dapper")]
        public async Task<ActionResult<List<EmployeeData>>> Get()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var emp = await connection.QueryAsync<EmployeeData>("SELECT * FROM Employee2");
            return Ok(emp);
        }

        [HttpGet("ADO.Net")]
        public IActionResult GetUsingADO()
        {
            return Ok(empReop.Get());
        }

        [HttpPost]
        public IActionResult PostData(EmployeeData emp)
        {
            return Ok(empReop.Post(emp));
        }

        [HttpPut]
        public IActionResult UpdateData(EmployeeData emp, int Id)
        {
            return Ok(empReop.Update(emp, Id));
        }


        [HttpDelete]
        public IActionResult DeleteEmployee(int Id)
        {
            return Ok(empReop.Delete(Id));
        }
    }
}
