using FunctionalCore;
using Microsoft.AspNetCore.Cors;

var builder = WebApplication.CreateBuilder(args);

// builder.WebHost.UseUrls("http://0.0.0.0:4045");

// Add CORS services
builder.Services.AddCors(options =>
{
  options.AddPolicy(name: "AllowAll",
      policy =>
      {
        policy.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
      });
});

var app = builder.Build();

var user = User.create("Alice", 30);

// Use CORS middleware
app.UseCors("AllowAll");

// Map the /hello endpoint with the CORS policy
app.MapGet("/hello", () => Say.hello(user.Name))
   .WithMetadata(new EnableCorsAttribute("AllowAll"));

app.Run();