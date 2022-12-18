using Microsoft.AspNetCore.Mvc;
using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL.Entities;

namespace NodesApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly IService<Message> _messageService;

        public MessageController(IService<Message> messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
