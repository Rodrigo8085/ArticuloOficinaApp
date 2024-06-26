
using ArticuloOfficinaApp.DataAccessLayer.Repository;
using ArticuloOficinaApp.BusinessLogicLayer.Service;
using ArticuloOficinaApp.DataAccessLayer.Context;
using ArticuloOficinaApp.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Se añaden conexion a Base de datos 
var connectionString = builder.Configuration.GetConnectionString("Connection");
builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseSqlServer(
            connectionString,
            x => x.MigrationsAssembly("ArticuloOfficinaApp.DataAccessLayer")
));

// Repositories 
builder.Services.AddScoped<IGenericRepository<Articulos>, ArticuloRepository>();
builder.Services.AddScoped<IGenericRepository<Cliente>, ClienteRepository>();
builder.Services.AddScoped<IGenericRepository<Tienda>, TiendaRepository>();
builder.Services.AddScoped<ILoginRepository<Login>, LoginRepository>();
builder.Services.AddScoped<IGenericRepository<Tienda_Articulos>, TiendaArticulosRepository>();
builder.Services.AddScoped<IGenericRepository<Venta>, VentaRepository>();

// Services
builder.Services.AddScoped<IArticulosService, ArticuloService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IVentaService, VentaService>();


var app = builder.Build();


app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
