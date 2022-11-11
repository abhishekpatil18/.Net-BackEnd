using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API_App1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbhishekController : ControllerBase
    {
        // GET: api/<AbhishekController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AbhishekController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AbhishekController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AbhishekController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AbhishekController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
