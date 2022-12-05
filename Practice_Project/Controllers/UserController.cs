using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Practice_Project.AuthenticationClasses;
using Practice_Project.Context;
using Practice_Project.Model;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Practice_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _Context;
        private readonly JWTSetting _Setting;

        public UserController(DataContext context, IOptions<JWTSetting> setting)
        {
            _Context = context;
            _Setting = setting.Value;
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate(User user)
        {
            var _user = _Context.Users.FirstOrDefault(u =>u.userName == user.userName && u.password == user.password);

                if (_user == null) return Unauthorized();

            var tockenHandler = new JwtSecurityTokenHandler();
            var tockenKey = Encoding.UTF8.GetBytes(_Setting.securityKey);
            var tockenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity
                (

                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, _user.userName)
                    }
                ),
                Expires = DateTime.Now.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tockenKey),SecurityAlgorithms.HmacSha256)
            };

            var tocken = tockenHandler.CreateToken(tockenDescriptor);
            var finalTocken = tockenHandler.WriteToken(tocken);
            return Ok(finalTocken);
        }
    }
}
