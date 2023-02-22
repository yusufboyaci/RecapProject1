using Microsoft.AspNetCore.Mvc;

namespace RecapUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
