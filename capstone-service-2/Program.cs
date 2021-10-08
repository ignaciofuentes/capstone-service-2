var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/my-service", () => "Hello from .NET App 123");

app.Run();
