using Microsoft.AspNetCore.Mvc;

namespace VsIGBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
