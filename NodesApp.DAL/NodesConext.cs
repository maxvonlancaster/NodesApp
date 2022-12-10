using Microsoft.EntityFrameworkCore;
using NodesApp.DAL.Entities;

namespace NodesApp.DAL
{
    public class NodesConext : DbContext
    {
        DbSet<Comment> Comments { get; set; }
        DbSet<Node> Nodes { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<User> Users { get; set; }


    }
}