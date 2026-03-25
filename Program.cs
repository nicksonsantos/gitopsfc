var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:8080");

var app = builder.Build();

app.MapGet("/", () => Results.Content("<h1>Hello Full Cycle</h1>", "text/html"));

app.Run();
