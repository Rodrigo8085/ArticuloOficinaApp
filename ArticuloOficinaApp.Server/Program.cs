
using ArticuloOfficinaApp.DataAccessLayer.Repository;
using ArticuloOficinaApp.BusinessLogicLayer.Service;
using ArticuloOficinaApp.DataAccessLayer.Context;

using ArticuloOficinaApp.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Se añaden conexion a Base de datos 

var connectionString = builder.Configuration.GetConnectionString("Connection");

// Registrar servicio para la conexion
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);


builder.Services.AddScoped<IGenericRepository<Articulos>>();
builder.Services.AddScoped<IArticulosService, ArticuloService>(); 


app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
