
using Microsoft.AspNetCore.Mvc;

namespace Maxim_free_task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
