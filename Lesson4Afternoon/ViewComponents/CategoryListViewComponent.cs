using Lesson4Afternoon.Data;
using Lesson4Afternoon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Lesson4Afternoon.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ProductDbContext _context;

        public CategoryListViewComponent(ProductDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke()
        {
            var categories = _context.Categories.Select(c =>
            new CategoryViewModel
            {
                Title = c.Title,
            });

            var vm = new CategoryListViewModel
            {
                Categories = categories.ToList()
            };
            return View(vm);
        }
    }
}
