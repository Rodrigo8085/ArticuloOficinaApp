
using ArticuloOfficinaApp.DataAccessLayer.Repository;
using ArticuloOficinaApp.BusinessLogicLayer.Service;
using ArticuloOficinaApp.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Se añaden conexion a Base de datos 
var connectionString = builder.Configuration.GetConnectionString("Connection");
//registrar servicio para la conexion
//builder.Services.AddDbContext<AppDbContext>(
//    options => options.UseSqlServer(connectionString)
//);

builder.Services.AddDbContext<AppDbContext>(
    options =>
        options.UseSqlServer(
            connectionString,
            x => x.MigrationsAssembly("ArticuloOfficinaApp.DataAccessLayer")
));

var app = builder.Build();





//builder.Services.AddScoped<IGenericRepository<Articulos>> ();
//builder.Services.AddScoped<IArticulosService, ArticuloService>();

//builder.Services.AddScoped<IGenericRepository<Articulos>>();
//builder.Services.AddScoped<ArticuloRepository, ArticuloRepository>();


app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
