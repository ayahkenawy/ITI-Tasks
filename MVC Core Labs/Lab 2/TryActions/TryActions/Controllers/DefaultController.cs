using Microsoft.AspNetCore.Mvc;

namespace TryActions.Controllers
{
    public class DefaultController : Controller
    {
        public string Welcome()
        {
            return "Welcome User";
        }
    }
}
