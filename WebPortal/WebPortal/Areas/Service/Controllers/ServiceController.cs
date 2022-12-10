using Microsoft.AspNetCore.Mvc;

namespace WebPortal.Areas.Service.Controllers
{
	[Area("Service")]
	[Route("[controller]/[action]")]
	public class ServiceController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
