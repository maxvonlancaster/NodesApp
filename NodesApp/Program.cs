using NodesApp;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services); // calling ConfigureServices method

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

startup.Configure(app, builder.Environment); // calling Configure method

