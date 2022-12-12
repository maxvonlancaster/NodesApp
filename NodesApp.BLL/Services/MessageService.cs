using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp.BLL.Services
{
    public class MessageService : IService<Message>
    {
        private readonly NodesConext _context;

        public MessageService(NodesConext context)
        {
            _context = context;
        }

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
