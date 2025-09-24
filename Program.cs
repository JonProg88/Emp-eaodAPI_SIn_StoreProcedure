//using EmpleadoAPI_SIn_StoreProcedure.Data;
//using EmpleadoAPI_SIn_StoreProcedure.Interfaces;
//using EmpleadoAPI_SIn_StoreProcedure.Services;
using EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Implementacion;
using EmpñeaodAPI_SIn_StoreProcedure.Bussiness.Services;
using EmpñeaodAPI_SIn_StoreProcedure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Conexión SQL Server
builder.Services.AddDbContext<EmpleadosDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Inyecciones
//builder.Services.AddScoped<IEmpleadoRepository, EmpleadoRepository>();

builder.Services.AddScoped<IEmpleadoReppository,EmpleadoRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
