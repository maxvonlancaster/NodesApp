using Microsoft.EntityFrameworkCore;
using NodesApp.DAL.Entities;

namespace NodesApp.DAL
{
    public class NodesConext : DbContext
    {
        public NodesConext(DbContextOptions options) : base(options)
        {
        }

        public NodesConext()
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<NodeSettings> NodeSettings { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Reaction> Reactions { get; set; }
        public virtual DbSet<UserNode> UserNodes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) 
        //{
        //    //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        //    //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        //}

    }
}