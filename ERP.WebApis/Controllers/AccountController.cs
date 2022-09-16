using ERP.WebApps.Core.ViewModel.Authenticate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ERP.WebApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [Route("Authenticate")]
        [HttpPost]
        public async Task<IActionResult> Authenticate([FromBody] LoginViewModel model)
        {
            //var user = await accountRepo.AuthenticateAndLoadUser(loginUser.Username, loginUser.Password);
            //validate user account in sql server
            var user = "ada";
            if (!(model.Username == user))
                throw new Exception("Invalid Login Credentials");

            // generate JWT Token
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key")));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
            var tokeOptions = new JwtSecurityToken(
                issuer: _configuration.GetValue<string>("JWT:Issuer"),
                audience: _configuration.GetValue<string>("JWT:Audience"),
                claims: new List<Claim>()
                {
                    new Claim("Name", "Tamim"),
                    new Claim("Role", "SuperAdmin"),
                },
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: signinCredentials);
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return Ok(tokenString);
        }
    }
}
