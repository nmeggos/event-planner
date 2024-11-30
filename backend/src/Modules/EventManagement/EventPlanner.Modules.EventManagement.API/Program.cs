var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

namespace EventPlanner.Modules.EventManagement.API
{
    public partial class Program {}
}