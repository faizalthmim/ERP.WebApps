using ERP.WebApps.Core.Interfaces;
using ERP.WebApps.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using ERP.WebApps.Base;
using ERP.WebApps.Core.ViewModel.Privacy;

namespace ERP.WebApps.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;
        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [Authorize]
        public IActionResult Index()
        {
            var access_token = "";
            var claims = HttpContext.User.Claims.ToList().Find(r => r.Type == "Authentication");
            access_token = (claims != null) ? claims.Value : access_token;
            //decrypt token
            JwtSecurityTokenHandler hand = new JwtSecurityTokenHandler();
            //read the token as recommended by Coxkie and dpix
            var tokenS = hand.ReadToken(access_token);
            var jwtPayload = ((JwtSecurityToken)tokenS).Payload;
            CurrentUserName = (string)jwtPayload.FirstOrDefault(o => o.Key == "Name").Value;
            CurrentUserRole = (string)jwtPayload.FirstOrDefault(o => o.Key == "Role").Value;









            return View();
        }
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize]
        public IActionResult Create()
        {
            var model = new UserViewModel();
            return PartialView("CreateEdit", model);
        }

        [Authorize]
        public IActionResult Edit(string id)
        {
            var model = new UserViewModel();
            var user = _userService.FindByID(id);
            if(user != null)
            {
                model.USER_ID = user.USER_ID;
                model.USER_NAME = user.USER_NAME;
                model.PWD = user.PWD;
            }
            return PartialView("CreateEdit", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}