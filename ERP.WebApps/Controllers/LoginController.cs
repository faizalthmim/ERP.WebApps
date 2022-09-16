using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using ERP.WebApps.Core.ViewModel.Authenticate;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Data;

namespace ERP.WebApps.Controllers
{
    public class LoginController : Controller
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Authenticate(LoginViewModel model)
        {
            //var user = await accountRepo.AuthenticateAndLoadUser(loginUser.Username, loginUser.Password);
            //validate user account in sql server
            var user = "ada" ;
            if (user == null)
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

            //add jwt token to user claims for authentication
            var claims = new List<Claim>
                        {
                            new Claim("Name", "JWT.Authentication"),
                            new Claim("Authentication", tokenString),

                        };
            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = true,
                //// Refreshing the authentication session should be allowed.

                //ExpiresUtc = new DateTimeOffset(DateTime.Today.AddMinutes(60)),
                //// The time at which the authentication ticket expires. A 
                //// value set here overrides the ExpireTimeSpan option of 
                //// CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                //// Whether the authentication session is persisted across 
                //// multiple requests. When used with cookies, controls
                //// whether the cookie's lifetime is absolute (matching the
                //// lifetime of the authentication ticket) or session-based.

                //IssuedUtc = DateTimeOffset.UtcNow,
                //// The time at which the authentication ticket was issued.
            };
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                claimsPrincipal,
                authProperties);
            //save to session also
            HttpContext.Session.SetString("userName", "Tamim");
            //HttpContext.Session.SetString("roles", "coba dulu");
            //HttpContext.Session.SetString("groupRoles", "coba dulu");

            return RedirectToAction("Index", "Home");
        }
    }
}
