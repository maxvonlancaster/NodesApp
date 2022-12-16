using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;
using NodesApp.DAL.Exceptions;

namespace NodesApp.BLL.Services
{
    public class MessageService : IService<Message>
    {
        private readonly NodesConext _context;

        public MessageService(NodesConext context)
        {
            _context = context;
        }

        public long Add(Message entity)
        {
            _context.Messages.Add(entity);
            _context.SaveChanges();
            return entity.MessageId;
        }

        public void Delete(long id)
        {
            var entity = _context.Messages.Find(id);
            if (entity == null)
            {
                return;
            }
            _context.Messages.Remove(entity);
            _context.SaveChanges();
        }

        public Message Get(long id)
        {
            var entity = _context.Messages.Find(id);
            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(Comment));
            }
            return entity;
        }

        public IEnumerable<Message> Get(Predicate<Message> condition)
        {
            return _context.Messages.Where(x => condition(x)).ToList();
        }

        public int Update(IEnumerable<Message> entity)
        {
            _context.Messages.UpdateRange(entity);
            return _context.SaveChanges();
        }
    }
}
