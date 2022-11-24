using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationFrameWork.Controllers
{
    public class CalculatorController : ApiController
    {
        
        public IEnumerable<string> Get()
        {
            return new string[] {
                CalcFunctions.CalcOperation.Add(10,20),
                CalcFunctions.CalcOperation.Sub(89,67),
                CalcFunctions.CalcOperation.Mult(10,90),
                CalcFunctions.CalcOperation.Div(78,9),
            };
        }


    }
}
