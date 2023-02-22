using Microsoft.AspNetCore.Mvc;

namespace RecapUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
