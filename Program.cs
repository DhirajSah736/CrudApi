using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using CrudApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCors(options =>
{
    //options.AddPolicy("AllowReactApp", builder =>
    //    builder.WithOrigins("http://localhost:5173")
    //           .AllowAnyMethod()
    //           .AllowAnyHeader());

    options.AddPolicy("AllowReactApp", builder =>
        builder.WithOrigins("http://localhost:3000") // Update the port to match your React app
               .AllowAnyMethod()
               .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseCors("AllowReactApp");
app.UseAuthorization();
app.MapControllers();
app.Run();
