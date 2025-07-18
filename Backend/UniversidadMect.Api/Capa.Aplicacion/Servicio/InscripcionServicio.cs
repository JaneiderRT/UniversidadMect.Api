using Capa.Dominio.Entidades;
using Serilog.Context;
using System.ComponentModel.DataAnnotations;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;

namespace UniversidadMect.Api.Capa.Aplicacion.Servicio
{
    public class InscripcionServicio : IInscripcionServicio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;
        private readonly ILogger<InscripcionServicio> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InscripcionServicio(IUnidadTrabajo unidadTrabajo, IHttpContextAccessor httpContextAccessor, ILogger<InscripcionServicio> logger)
        {
            _unidadTrabajo = unidadTrabajo;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
            LogContext.PushProperty("CorrelationId", GetCorrelacionId());
        }
        public async Task<Inscripcion> ActualizarInscripcion(ActualizarInscripcionDTO inscripcion)
        {
            Inscripcion inscripcionBD = await _unidadTrabajo.iInscripcionRepositorio.GetById(inscripcion.InscripcionId);
            if (inscripcionBD == null)
            {
                throw new ValidationException("El id de la inscripción no existe.");
            }
            inscripcionBD.InscripcionId = inscripcion.InscripcionId;
            inscripcionBD.EstudianteId = inscripcion.EstudianteId;
            inscripcionBD.MateriaId = inscripcion.MateriaId;
            inscripcionBD.EsActivo = inscripcion.EsActivo;

            _unidadTrabajo.iInscripcionRepositorio.Update(inscripcionBD);
            await _unidadTrabajo.SaveChangesAsync();
            return inscripcionBD;
        }

        public async Task<IEnumerable<InscripcionDTO>> ConsultarInscripciones()
        {
            return await _unidadTrabajo.iInscripcionRepositorio.ConsultarInscripciones();
        }

        public async Task<IEnumerable<InscripcionDTO>> ConsultarInscripcionesPorEstudianteId(int estudianteId)
        {
            if (estudianteId <= 0)
            {
                throw new ValidationException("El id del estudiante no puede ser menor o igual a cero.");
            }

            Estudiante estudiante = await _unidadTrabajo.iEstudianteRepositorio.GetById(estudianteId);

            if (estudiante == null)
            {
                throw new ValidationException("El id del estudiante no existe.");
            }

            return await _unidadTrabajo.iInscripcionRepositorio.ConsultarInscripcionesPorEstudianteId(estudianteId);
        }

        public async Task<bool> InactivarInscripcion(int inscripcionId)
        {
            Inscripcion inscripcionBD = await _unidadTrabajo.iInscripcionRepositorio.GetById(inscripcionId);
            if (inscripcionBD == null)
            {
                throw new ValidationException("El id de la inscripción no existe.");
            }
            inscripcionBD.EsActivo = false;
            _unidadTrabajo.iInscripcionRepositorio.Update(inscripcionBD);
            await _unidadTrabajo.SaveChangesAsync();
            return true;
        }

        public async Task<Inscripcion> InsertarInscripcion(Inscripcion inscripcion)
        {
            IEnumerable<InscripcionDTO> inscripcionesEstudiante = await _unidadTrabajo.iInscripcionRepositorio.ConsultarInscripcionesPorEstudianteId(inscripcion.EstudianteId);
            if (inscripcionesEstudiante.Any(i => i.MateriaId == inscripcion.MateriaId && i.EsActivo))
            {
                _logger.LogWarning("El estudiante con ID {EstudianteId} ya está inscrito en la materia con ID {MateriaId}. Correlación: {CorrelationId}",
                    inscripcion.EstudianteId, inscripcion.MateriaId, GetCorrelacionId());
                throw new ValidationException("El estudiante ya está inscrito en esta materia.");
            }
            if ((inscripcionesEstudiante.Count(i => i.EsActivo == true) + 1) > 3)
            {
                _logger.LogWarning("El estudiante con ID {EstudianteId} ha alcanzado el límite de inscripciones activas. Correlación: {CorrelationId}",
                    inscripcion.EstudianteId, GetCorrelacionId());
                throw new ValidationException("El estudiante no puede inscribirse en más de 3 materias activas.");
            }

            MateriaDTO materia = await _unidadTrabajo.iMateriaRepositorio.ConsultarMateriaPorId(inscripcion.MateriaId);
            if (inscripcionesEstudiante.Any(i => i.ProfesorId == materia.ProfesorId))
            {
                _logger.LogWarning("El estudiante con ID {EstudianteId} ya está inscrito en una materia con el profesor con ID {ProfesorId}. Correlación: {CorrelationId}",
                    inscripcion.EstudianteId, materia.ProfesorId, GetCorrelacionId());
                throw new ValidationException("El estudiante no puede inscribirse en más de 1 materia con el mismo profesor.");
            }

            inscripcion.EsActivo = true;
            inscripcion.FechaCreacion = DateTime.Now;
            inscripcion.CreadoPor = 1;
            await _unidadTrabajo.iInscripcionRepositorio.Insert(inscripcion);
            await _unidadTrabajo.SaveChangesAsync();
            return inscripcion;
        }

        private string GetCorrelacionId()
        {
            return _httpContextAccessor.HttpContext?.Items["CorrelationId"]?.ToString() ?? "N/A";
        }
    }
}
