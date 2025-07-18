# Versiones

- **npm**: 10.9.2
- **Node.js**: 22.17.0
- **.NET**: 8.0.412 (Para .NET Core 8.0)

# Base de Datos (BDD)

La base de datos es **SQL Server**.

## Ejecución Script Parametrización

Ejecutar el script: [ScriptEstructuraYData.sql](/sql/ScriptEstructuraYData.sql)

> Este script creará la base de datos, las tablas con sus relaciones e insertará datos en las mismas.

## Modificar Cadena De Conexión BDD

Asegúrate de modificar la cadena de conexión en el archivo de configuración para que apunte a tu servidor de SQL Server en el fuente:
[appsettings.json](Backend/UniversidadMect.Api/appsettings.json)

> Puedes modificar la cadena que prefieras según tu necesidad: *"DefaultConnection"* o la *"DockerConnection"*

Una vez modifiques la cadena de conexión en el **appsettings.json**, debes asegurarte de que se esté inyectando la correcta,
eso lo validas en el fuente: [Program.cs](Backend/UniversidadMect.Api/Program.cs)

En la región **Configuracion Context**:
~~~
#region Configuracion Context
builder.Services.AddDbContext<UniversidadContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DockerConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<UniversidadContext>();
#endregion
~~~

Y en la región **Configuración de Logging**
~~~
#region Configuración de Logging
...
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("System", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.MSSqlServer(
        connectionString: builder.Configuration.GetConnectionString("DockerConnection"),
        sinkOptions: new MSSqlServerSinkOptions { TableName = "Logs", SchemaName = "dbo", BatchPostingLimit = 1, AutoCreateSqlTable = true },
        columnOptions: columnOptions)
    .CreateLogger();
...
#endregion
~~~

# Configuración A Tener En Cuenta

Asegurate que el proyecto de frontend levante en el puerto **http://localhost:5173**; de no ser así, en el fuente [Program.cs](Backend/UniversidadMect.Api/Program.cs) dentro de la región **Configuracion De Cors** puedes cambiar el puerto para que el
navegador no bloqueé las peticiones que provienen de esa dirección:
~~~
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
~~~
