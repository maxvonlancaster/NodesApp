using Microsoft.AspNetCore.Mvc;
using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL.Entities;
using NodesApp.Models;

namespace NodesApp.Controllers
{
    public class NodesController : Controller
    {
        private readonly INodeService _nodeService;

        public NodesController(INodeService nodeService)
        {
            _nodeService = nodeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateNode() 
        {
            return View("~/Pages/Views/Nodes/CreateNode.cshtml");
        }

        public IActionResult ListNodes()
        {
            var entities = _nodeService.Get(x => true).ToList();
            return View("~/Pages/Views/Nodes/ListNodes.cshtml", entities);
        }

        public IActionResult Node(long id)
        {
            var node = _nodeService.Get(id);

            if (node == null)
            {
                return NotFound();
            }

            return View("~/Pages/Views/Nodes/Node.cshtml", node);
        }
        

        [HttpPost]
        public IActionResult PostNode([FromBody]NodeModel model) 
        {
            model.DateCreated = DateTime.Now;
            var id = _nodeService.Add(model.ToEntity());
            return View("~/Pages/Views/Nodes/Node.cshtml");
        }

        [HttpPut("{id}")]
        public IActionResult PutNode(long id, NodeModel node)
        {
            if (id != node.NodeId)
            {
                return BadRequest();
            }

            _nodeService.Update(new List<Node>() { node.ToEntity() });

            

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNode(long id)
        {
            _nodeService.Delete(id);
            return NoContent();
        }


    }
}
