using System.Collections.ObjectModel;
using System.Data;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Aplicacion.Servicio;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;
using UniversidadMect.Api.Capa.Infraestructura.Automapper;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Logging;
using UniversidadMect.Api.Capa.Infraestructura.Repositorio.UnidadTrabajo;

var builder = WebApplication.CreateBuilder(args);

#region Configuracion Context
builder.Services.AddDbContext<UniversidadContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DockerConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<UniversidadContext>();
#endregion

#region Configuración de Logging
var columnOptions = new ColumnOptions();
columnOptions.Store.Clear();
columnOptions.Store.Add(StandardColumn.Message);
columnOptions.Store.Add(StandardColumn.MessageTemplate);
columnOptions.Store.Add(StandardColumn.Level);
columnOptions.Store.Add(StandardColumn.TimeStamp);
columnOptions.Store.Add(StandardColumn.Exception);
columnOptions.Store.Add(StandardColumn.Properties);
columnOptions.AdditionalColumns = new Collection<SqlColumn>
{
    new SqlColumn { ColumnName = "UserName", DataType = SqlDbType.NVarChar, DataLength = 30 },
    new SqlColumn { ColumnName = "CorrelationId", DataType = SqlDbType.NVarChar, DataLength = 100 },
};


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("System", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.MSSqlServer(
        connectionString: builder.Configuration.GetConnectionString("DockerConnection"),
        sinkOptions: new MSSqlServerSinkOptions { TableName = "Logs", SchemaName = "dbo", BatchPostingLimit = 1, AutoCreateSqlTable = true },
        columnOptions: columnOptions)
    .CreateLogger();

builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();
    loggingBuilder.AddSerilog();
});

Log.Information("Inicia la API Universidad correctamente");
#endregion


#region Inyeccion De Servicios
builder.Services.AddScoped<IEstudianteServicio, EstudianteServicio>();
builder.Services.AddScoped<IUniversidadServicio, UniversidadServicio>();
builder.Services.AddScoped<IProfesorServicio, ProfesorServicio>();
builder.Services.AddScoped<IProgramaServicio, ProgramaServicio>();
builder.Services.AddScoped<IMateriaServicio, MateriaServicio>();
builder.Services.AddScoped<IInscripcionServicio, InscripcionServicio>();
#endregion

#region Crud Generico
builder.Services.AddScoped(typeof(ICrudSql<>), typeof(CrudSql<>));
#endregion

#region Unidad De Trabajo
builder.Services.AddTransient<IUnidadTrabajo, UnidadTrabajo>();
#endregion

#region Configuracion De Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AppReact", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});
#endregion

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MapperProfile>();
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AppReact");

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
