using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class MessageService : IService<Message>
    {
        public int Add(Message entity)
        {
            throw new NotImplementedException();
        }

        public Message Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Message Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Message> Get(Predicate<Message> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<Message> entity)
        {
            throw new NotImplementedException();
        }
    }
}
