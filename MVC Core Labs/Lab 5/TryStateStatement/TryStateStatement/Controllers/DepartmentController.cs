using Microsoft.AspNetCore.Mvc;

namespace TryStateStatement.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
