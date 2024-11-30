

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var environment = builder.Environment;


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

public partial class Program {}