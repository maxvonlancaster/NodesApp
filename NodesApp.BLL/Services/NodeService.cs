using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;
using System.Linq.Expressions;

namespace NodesApp.BLL.Services
{
    public class NodeService : INodeService
    {
        private readonly NodesConext _context;

        public NodeService(NodesConext context)
        {
            _context = context;
        }

        public long Add(Node entity)
        {
            _context.Nodes.Add(entity);
            _context.SaveChanges();
            return entity.NodeId;
        }

        public void Delete(long id)
        {
            var entity = _context.Nodes.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Nodes.Remove(entity);
            _context.SaveChanges();
        }

        public Node Get(long id)
        {
            var entity = _context.Nodes.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<Node> Get(Expression<Func<Node, bool>> condition, int skip, int take)
        {
            return _context.Nodes
                .Where(condition)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public Node GetNodeByLink(string link)
        {
            var entity = _context.Nodes
                .FirstOrDefault(x => x.Link == link);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public int Update(IEnumerable<Node> entity)
        {
            _context.Nodes.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
