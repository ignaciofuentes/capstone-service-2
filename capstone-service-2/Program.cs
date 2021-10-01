var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/service2", () => "Hello .net app 12345");

app.Run();
