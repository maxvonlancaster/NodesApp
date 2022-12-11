using Microsoft.EntityFrameworkCore;
using NodesApp.DAL.Entities;

namespace NodesApp.DAL
{
    public class NodesConext : DbContext
    {
        public NodesConext()
        {
        }

        DbSet<Comment> Comments { get; set; }
        DbSet<Node> Nodes { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<NodeSettings> NodeSettings { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Reaction> Reactions { get; set; }


    }
}