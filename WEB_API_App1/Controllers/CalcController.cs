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
            API_Calculator.Class1.Mult(45, 4),
            API_Calculator.Class1.Div(81, 9),
         };
        }
    }
}
