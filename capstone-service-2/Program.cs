var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/my-service", () => "Demo Service");

app.Run();
