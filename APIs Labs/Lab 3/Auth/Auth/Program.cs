using Auth.Data;
using Auth.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options => options.
UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDb")));

builder.Services.AddIdentity<Employee, IdentityRole>(
    options =>
    {
        options.Password.RequireNonAlphanumeric=false;
        options.Password.RequiredLength = 8;
        //options.User.RequireUniqueEmail = true; 
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    }).AddEntityFrameworkStores<Context>() ;

// build identity
builder.Services.AddAuthentication(options =>
{
    options.DefaultChallengeScheme = "AuthName";
    options.DefaultAuthenticateScheme = "AuthName";
}).AddJwtBearer("AuthName",
    options =>
    {
        var secretKey = builder.Configuration.GetValue<string>("SecretKey");
        var keyInBytes = Encoding.ASCII.GetBytes(secretKey);
        var key = new SymmetricSecurityKey(keyInBytes);
        options.TokenValidationParameters = new TokenValidationParameters
        {
            IssuerSigningKey = key,
            ValidateIssuer = false,
            ValidateAudience = false,
        };

    });
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("EG", policy => policy.RequireClaim("Nationality", "Egyptian"));
    });
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
