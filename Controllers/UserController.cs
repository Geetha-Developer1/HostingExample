using Microsoft.AspNetCore.Mvc;

namespace HostingExample.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
