using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class CommentService : IService<Comment>
    {
        private readonly NodesConext _context;

        public CommentService(NodesConext context)
        {
            _context = context;
        }

        public int Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Comment Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> Get(Predicate<Comment> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<Comment> entity)
        {
            throw new NotImplementedException();
        }
    }
}
