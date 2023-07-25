using AmazonWebApp.Data;
using AmazonWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonWebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AmazonDbContext _db;

        public CategoryController(AmazonDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategories=_db.Categories.ToList();
            return View(objCategories);
        }
    }
}
