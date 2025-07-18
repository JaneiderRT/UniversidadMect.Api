using Serilog.Context;
using System.ComponentModel.DataAnnotations;

namespace UniversidadMect.Api.Capa.Infraestructura.Logging
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var correlacionId = context.Request.Headers["X-Correlation-ID"].FirstOrDefault() ?? Guid.NewGuid().ToString();
            context.Items["CorrelationId"] = correlacionId;

            var usuario = context.User.Identity?.IsAuthenticated == true ? context.User.Identity.Name : "Invitado";

            context.Items["UserName"] = usuario;
            context.Response.Headers.Add("X-Correlation-ID", correlacionId);

            try
            {
                LogContext.PushProperty("CorrelationId", correlacionId);
                LogContext.PushProperty("UserName", usuario);
                await _next(context);
            }
            catch (ValidationException ex)
            {
                _logger.LogWarning(ex, "Excepción de validación");
                context.Response.StatusCode = StatusCodes.Status422UnprocessableEntity;
                context.Response.ContentType = "application/json";

                await context.Response.WriteAsJsonAsync(new
                {
                    error = ex.Message,
                    correlacionId
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error no controlado: {Message}", ex.Message);

                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(new
                {
                    error = "Error inesperado",
                    correlacionId
                });
            }
        }
    }
}
