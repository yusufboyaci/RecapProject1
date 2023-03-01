using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Recap.Business.Abstract;
using RecapUI.Models;
using System.Security.Claims;

namespace RecapUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost("[controller]/Login")]
        public async Task<IActionResult> Login([FromBody] LoginVM login)
        {
            if (_userService.CheckCredential(login.Username, login.Password))
            {
                if (login.Username != null || login.Password != null)
                {
                    List<Claim> claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name,login.Username)
                    };
                    ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return Json(true);
                }
            }
            return Json(false);
        }
        [HttpGet("[controller]")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("login", "login");
        }
    }
}
