using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services.Interfaces
{
    public interface IUserService : IService<User>
    {
        public User GetByUserName(string userName);
        public User GetByCredentials(string userName, string password);
    }
}
