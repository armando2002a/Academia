using Datos.DataDb;
using Microsoft.EntityFrameworkCore;
using Repositorios.Asignatura;
using Repositorios.Aula;
using Repositorios.Colaborador;
using Repositorios.Docente;
using Repositorios.Estudiante;
using Repositorios.Horario;
using Repositorios.InformacionDetalladaClases;
using Repositorios.Matricula;
using Repositorios.Nota;
using Servicio.Asignatura;
using Servicio.Aula;
using Servicio.Colaborador;
using Servicio.Docente;
using Servicio.Estudiante;
using Servicio.Horario;
using Servicio.InformacionDetalladaClases;
using Servicio.Matricula;
using Servicio.Nota;

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

builder.Services.AddTransient<IAsignaturaRepositorio, AsignaturaRepositorio>();
builder.Services.AddScoped<IAsignaturaServicio, AsignaturaServicio>();

builder.Services.AddTransient<IHorarioRepositorio, HorarioRepositorio>();
builder.Services.AddScoped<IHorarioServicio, HorarioServicio>();

builder.Services.AddTransient<INotaRepositorio, NotaRepositorio>();
builder.Services.AddScoped<INotaServicio, NotaServicio>();

builder.Services.AddTransient<IAulaRepositorio, AulaRepositorio>();
builder.Services.AddScoped<IAulaServicio, AulaServicio>();

builder.Services.AddTransient<IMatriculaRepositorio, MatriculaRepositorio>();
builder.Services.AddScoped<IMatriculaServicio, MatriculaServicio>();

builder.Services.AddTransient<IDetallesClaseRepositorio, DetallesClaseRepositorio>();
builder.Services.AddScoped<IDetallesClaseServicio, DetallesClaseServicio>();


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
