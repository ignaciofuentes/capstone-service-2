var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/my-service", () => "Hello .net app 12345");

app.Run();
