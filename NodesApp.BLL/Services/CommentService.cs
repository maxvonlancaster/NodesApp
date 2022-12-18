using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace NodesApp.BLL.Services
{
    public class CommentService : IService<Comment>
    {
        private readonly NodesConext _context;

        public CommentService(NodesConext context)
        {
            _context = context;
        }

        public long Add(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
            return entity.CommentId;
        }

        public void Delete(long id)
        {
            var entity = _context.Comments.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Comments.Remove(entity);
            _context.SaveChanges();
        }

        public Comment Get(long id)
        {
            var entity = _context.Comments.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<Comment> Get(Expression<Func<Comment, bool>> condition)
        {
            return _context.Comments.Where(condition).ToList();
        }

        public int Update(IEnumerable<Comment> entity)
        {
            _context.Comments.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
