using Microsoft.AspNetCore.Mvc;

namespace NodesApp.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
