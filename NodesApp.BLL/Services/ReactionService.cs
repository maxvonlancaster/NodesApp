using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class ReactionService : IService<Reaction>
    {
        private readonly NodesConext _context;

        public ReactionService(NodesConext context)
        {
            _context = context;
        }

        public int Add(Reaction entity)
        {
            throw new NotImplementedException();
        }

        public Reaction Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Reaction Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reaction> Get(Predicate<Reaction> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<Reaction> entity)
        {
            throw new NotImplementedException();
        }
    }
}
