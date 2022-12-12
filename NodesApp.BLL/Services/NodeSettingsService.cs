using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class NodeSettingsService : IService<NodeSettings>
    {
        private readonly NodesConext _context;

        public NodeSettingsService(NodesConext context)
        {
            _context = context;
        }

        public int Add(NodeSettings entity)
        {
            throw new NotImplementedException();
        }

        public NodeSettings Delete(int id)
        {
            throw new NotImplementedException();
        }

        public NodeSettings Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NodeSettings> Get(Predicate<NodeSettings> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<NodeSettings> entity)
        {
            throw new NotImplementedException();
        }
    }
}
