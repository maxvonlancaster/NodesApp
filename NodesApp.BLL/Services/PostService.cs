using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodesApp.BLL.Services
{
    public class PostService : IService<Post>
    {
        public int Add(Post entity)
        {
            throw new NotImplementedException();
        }

        public Post Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Post Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> Get(Predicate<Post> condition)
        {
            throw new NotImplementedException();
        }

        public int Update(IEnumerable<Post> entity)
        {
            throw new NotImplementedException();
        }
    }
}
