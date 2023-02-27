using Microsoft.AspNetCore.Mvc;
using RecapUI.Models;

namespace RecapUI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login() => View(); 
        [HttpPost("Login")]
        public IActionResult Login(LoginVM login)
        {
            if (true)
            {
                
            }
            return Json(true);
        }
    }
}
