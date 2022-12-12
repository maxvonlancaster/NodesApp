using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly NodesConext _context;

        public UserService(NodesConext context)
        {
            _context = context;
        }

        public int Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Get(Predicate<User> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<User> entity)
        {
            throw new NotImplementedException();
        }
    }
}
