using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;
using System.Linq.Expressions;

namespace NodesApp.BLL.Services
{
    public class NodeSettingsService : IService<NodeSettings>
    {
        private readonly NodesConext _context;

        public NodeSettingsService(NodesConext context)
        {
            _context = context;
        }

        public long Add(NodeSettings entity)
        {
            _context.NodeSettings.Add(entity);
            _context.SaveChanges();
            return entity.NodeSettingsId;
        }

        public void Delete(long id)
        {
            var entity = _context.NodeSettings.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.NodeSettings.Remove(entity);
            _context.SaveChanges();
        }

        public NodeSettings Get(long id)
        {
            var entity = _context.NodeSettings.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<NodeSettings> Get(Expression<Func<NodeSettings, bool>> condition, int skip, int take)
        {
            return _context.NodeSettings
                .Where(condition)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public int Update(IEnumerable<NodeSettings> entity)
        {
            _context.NodeSettings.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
