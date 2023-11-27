using Datos.DataDb;
using Microsoft.EntityFrameworkCore;
using Repositorios.Asignatura;
using Repositorios.Colaborador;
using Repositorios.Docente;
using Repositorios.Estudiante;
using Repositorios.Matricula;
using Servicio.Asignatura;
using Servicio.Colaborador;
using Servicio.Docente;
using Servicio.Estudiante;
using Servicio.Matricula;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(opcion => opcion.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRazorPages();

builder.Services.AddTransient<IEstudianteRepositorio, EstudianteRepositorio>();
builder.Services.AddScoped<IEstudianteServicio, EstudianteServicio>();

builder.Services.AddTransient<IDocenteRepositorio, DocenteRepositorio>();
builder.Services.AddScoped<IDocenteServicio, DocenteServicio>();

builder.Services.AddTransient<IColaboradorRepositorio, ColaboradorRepositorio>();
builder.Services.AddScoped<IColaboradorServicio, ColaboradorServicio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
