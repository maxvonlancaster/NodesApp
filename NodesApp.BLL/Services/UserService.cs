using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;

namespace NodesApp.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly NodesConext _context;

        public UserService(NodesConext context)
        {
            _context = context;
        }

        public long Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
            return entity.UserId;
        }

        public void Delete(long id)
        {
            var entity = _context.Users.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public User Get(long id)
        {
            var entity = _context.Users.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<User> Get(Predicate<User> condition)
        {
            return _context.Users
                .Where(x => condition(x)).ToList();
        }

        public User GetByUserName(string userName)
        {
            var entity = _context.Users
                .FirstOrDefault(x => x.UserName == userName);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public int Update(IEnumerable<User> entity)
        {
            _context.Users.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
