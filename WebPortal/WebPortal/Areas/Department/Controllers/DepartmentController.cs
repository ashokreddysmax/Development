using Microsoft.AspNetCore.Mvc;

namespace WebPortal.Areas.Department.Controllers
{
	[Area("Department")]
	[Route("[controller]/[action]")]
	public class DepartmentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
