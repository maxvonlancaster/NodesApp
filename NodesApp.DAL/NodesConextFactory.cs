using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NodesApp.DAL
{
    public class NodesConextFactory : IDesignTimeDbContextFactory<NodesConext>
    {
        public NodesConext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NodesConext>();
            optionsBuilder.UseSqlServer("Data Source=5CD116MK8R\\SQLEXPRESS;Initial Catalog=NodesDatabase;Integrated Security=True;TrustServerCertificate=True;");

            return new NodesConext(optionsBuilder.Options);
        }
    }
}
