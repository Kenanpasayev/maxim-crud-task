using Microsoft.AspNetCore.Mvc;

namespace Maxim_free_task.Areas.Manage.Controllers
{
	[Area("Manage")]
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
