using Microsoft.EntityFrameworkCore;
using RazorPageCRUD.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages(options=>options.Conventions.AddPageRoute("/EmployeePages/Index",""));
builder.Services.AddDbContext<Context>(options => options.UseSqlServer("Server=.;Database=NewHR;Trusted_Connection=true"));
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>endpoints.MapRazorPages());

app.Run();
