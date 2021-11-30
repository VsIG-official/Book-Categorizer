using Microsoft.AspNetCore.Mvc;
using VsIGBookWeb.Data;
using VsIGBookWeb.Models;

namespace VsIGBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _db.Categories;

            return View(categories);
        }
    }
}
