var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/service2", () => "Hello World 12345!");

app.Run();
