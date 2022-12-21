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
            var entities = _nodeService.Get(x => true, 0, 10).ToList();
            NodesListModel model = new NodesListModel();
            model.Nodes = new List<NodeModel>();
            foreach (var entity in entities) 
            {
                model.Nodes.Add(new NodeModel(entity));
            }
            return View("~/Pages/Views/Nodes/ListNodes.cshtml", model);
        }

        public IActionResult Node(long id)
        {
            var node = _nodeService.Get(id);

            if (node == null)
            {
                return NotFound();
            }

            return View("~/Pages/Views/Nodes/Node.cshtml", new NodeModel(node));
        }
        

        [HttpPost]
        public IActionResult PostNode([FromBody]NodeModel model) 
        {
            model.DateCreated = DateTime.Now;
            var id = _nodeService.Add(model.ToEntity());
            return RedirectToAction("ListNodes");
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

        public IActionResult ListNodes(string filter)
        {
            var entities = _nodeService
                .Get(x => x.Text.Contains(filter) || x.NodeName.Contains(filter), 0, 10)
                .ToList();
            NodesListModel model = new NodesListModel();
            model.Nodes = new List<NodeModel>();
            foreach (var entity in entities)
            {
                model.Nodes.Add(new NodeModel(entity));
            }
            return View("~/Pages/Views/Nodes/ListNodes.cshtml", model);
        }
    }
}
