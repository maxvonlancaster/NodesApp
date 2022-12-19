using Microsoft.EntityFrameworkCore;
using NodesApp.BLL.Services;
using NodesApp.BLL.Services.Interfaces;
using NodesApp.DAL;
using NodesApp.DAL.Entities;

namespace NodesApp
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddScoped<INodeService,NodeService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IService<Comment>, CommentService>();
            services.AddScoped<IService<Message>, MessageService>();
            services.AddScoped<IService<NodeSettings>, NodeSettingsService>();
            services.AddScoped<IService<Post>, PostService>();
            services.AddScoped<IService<Reaction>, ReactionService>();

            se‌​rvices.AddDbContext<NodesConext>(
                opt‌​ions => { options.UseSqlServer(configRoot.GetConnectionString("NodesConnectionString")); }
                
                );
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
