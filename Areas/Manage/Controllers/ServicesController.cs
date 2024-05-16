using Maxim_free_task.DAL;
using Maxim_free_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Maxim_free_task.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Services services) 
        {
            return RedirectToAction("Index");
        }
    }
}
