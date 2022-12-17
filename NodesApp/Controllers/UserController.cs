using Microsoft.AspNetCore.Mvc;

namespace NodesApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
