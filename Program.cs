var builder = WebApplication.CreateBuilder();
var app = builder.Build();
 
app.UseDefaultFiles();
app.UseStaticFiles();

Random rnd = new Random();

// app.MapGet("/", (HttpContext context) => context.Response.WriteAsync("<h2>Hello World</h2>"));
// app.MapGet("/", () => $"<h2>Your randow number from 1 to 6: {rnd.Next(1, 6)}</h2>");
app.MapGet("/", (HttpContext context) =>
{
    var randomNumber = rnd.Next(1, 6);
    context.Response.ContentType = "text/html";
    return context.Response.WriteAsync($"<h2>Your random number from 1 to 6: {randomNumber}</h2>");
});

app.Run();