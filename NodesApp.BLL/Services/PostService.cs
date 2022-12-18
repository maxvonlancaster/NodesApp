using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NodesApp.BLL.Services
{
    public class PostService : IService<Post>
    {
        private readonly NodesConext _context;

        public PostService(NodesConext context)
        {
            _context = context;
        }

        public long Add(Post entity)
        {
            _context.Posts.Add(entity);
            _context.SaveChanges();
            return entity.PostId;
        }

        public void Delete(long id)
        {
            var entity = _context.Posts.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Posts.Remove(entity);
            _context.SaveChanges();
        }

        public Post Get(long id)
        {
            var entity = _context.Posts.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<Post> Get(Expression<Func<Post, bool>> condition, int skip, int take)
        {
            return _context.Posts
                .Where(condition)
                .Skip(skip)
                .Take(take)
                .ToList();
        }

        public int Update(IEnumerable<Post> entity)
        {
            _context.Posts.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
