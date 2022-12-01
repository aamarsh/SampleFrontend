var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// adding comment one
// adding comment two and three and four

app.Run();
