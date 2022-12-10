using Microsoft.AspNetCore.Mvc;

namespace WebPortal.Areas.AboutUs.Controllers
{
	[Area("AboutUs")]
	[Route("[controller]/[action]")]
	public class AboutUsController : Controller
	{
		public IActionResult AboutUs()
		{
			return View();
		}
		public IActionResult Profile()
		{
			return View();
		}
		public IActionResult Team()
		{
			return View();
		}
	}
}
