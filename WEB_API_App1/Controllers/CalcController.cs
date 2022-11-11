using Microsoft.AspNetCore.Mvc;

namespace WEB_API_App1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        // GET: api/Calc
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {
            API_Calculator.Class1.Add(6, 8),
            API_Calculator.Class1.Sub(90, 27),
         };
        }

        //// GET api/Calc/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return $"value {id}";
        //}

        //// POST api/Calc
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/Calc/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/Calc/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
