using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services.Interfaces
{
    public interface IUserService : IService<User>
    {
        public User GetByUserName(string userName);
    }
}
