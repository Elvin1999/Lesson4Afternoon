using Lesson4Afternoon.Data;
using Lesson4Afternoon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lesson4Afternoon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _context;

        public HomeController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.Select(p => new ProductViewModel
            {
                Name = p.Name,
                Price= p.Price,
            }).ToList();

            var categories = _context.Categories.Select(c => new CategoryViewModel
            {
                Title = c.Title,
            }).ToList();

            var vm = new ProductCategoryListViewModel
            {
                Categories= categories,
                Products = products
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
