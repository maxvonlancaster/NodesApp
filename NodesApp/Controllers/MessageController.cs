using Microsoft.AspNetCore.Mvc;

namespace NodesApp.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
