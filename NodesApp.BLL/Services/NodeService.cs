using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class NodeService : INodeService
    {
        private readonly NodesConext _context;

        public NodeService(NodesConext context)
        {
            _context = context;
        }

        public int Add(Node entity)
        {
            throw new NotImplementedException();
        }

        public Node Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Node Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Node> Get(Predicate<Node> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<Node> entity)
        {
            throw new NotImplementedException();
        }
    }
}
