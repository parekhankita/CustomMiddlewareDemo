using CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Use your custom middleware
app.UseMiddleware<SimpleMiddleware>();

app.MapGet("/", () => "Hello from Middleware!");

app.Run();