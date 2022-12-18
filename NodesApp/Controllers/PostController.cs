using Microsoft.AspNetCore.Mvc;
using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL.Entities;

namespace NodesApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IService<Post> _postService;

        public PostController(IService<Post> postService)
        {
            _postService = postService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
