var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/my-service", () => "Hello from .NET App");

app.Run();
