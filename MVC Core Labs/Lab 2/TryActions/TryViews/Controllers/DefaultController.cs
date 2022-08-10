using Microsoft.AspNetCore.Mvc;

namespace TryViews.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
