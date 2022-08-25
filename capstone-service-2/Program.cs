var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/my-service", () => "Hello Tipico!");

app.Run();
