using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Profesor;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class ProfesorRepositorio : CrudSql<Profesor>, IProfesorRepositorio
    {
        private readonly UniversidadContext _context;

        public ProfesorRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProfesorDTO>> ConsultarProfesores()
        {
            return await _context.Profesor
                .Include(prof => prof.Persona)
                    .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                .Select(prof => new ProfesorDTO
                {
                    ProfesorId = prof.ProfesorId,
                    PersonaId = prof.PersonaId,
                    UniversidadId = prof.UniversidadId,
                    Codigo = prof.Codigo,
                    PrimerNombre = prof.Persona.PrimerNombre,
                    SegundoNombre = prof.Persona.SegundoNombre,
                    PrimerApellido = prof.Persona.PrimerApellido,
                    SegundoApellido = prof.Persona.SegundoApellido,
                    TipoIdentificacion = prof.Persona.TipoIdentificacion.Descripcion,
                    Identificacion = prof.Persona.Identificacion,
                    EsActivo = prof.EsActivo
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProfesorDTO>> ConsultarProfesorMateriasPorId(int id)
        {
            return await _context.Profesor
                .Include(prof => prof.Persona)
                    .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                .Join(_context.Materia,
                     prof => prof.ProfesorId,
                     mat => mat.ProfesorId,
                     (prof, mat) => new
                     {
                         Profesores = prof,
                         Materias = mat
                     }
                 )
                .Where(prof => prof.Profesores.ProfesorId == id)
                .Select(prof => new ProfesorDTO
                {
                    ProfesorId = prof.Profesores.ProfesorId,
                    PersonaId = prof.Profesores.PersonaId,
                    UniversidadId = prof.Profesores.UniversidadId,
                    Codigo = prof.Profesores.Codigo,
                    PrimerNombre = prof.Profesores.Persona.PrimerNombre,
                    SegundoNombre = prof.Profesores.Persona.SegundoNombre,
                    PrimerApellido = prof.Profesores.Persona.PrimerApellido,
                    SegundoApellido = prof.Profesores.Persona.SegundoApellido,
                    TipoIdentificacion = prof.Profesores.Persona.TipoIdentificacion.Descripcion,
                    Identificacion = prof.Profesores.Persona.Identificacion,
                    EsActivo = prof.Profesores.EsActivo,
                    NombreMateria = prof.Materias.Nombre
                })
                .ToListAsync();
        }

        public async Task<ProfesorDTO> ConsultarProfesorPorId(int id)
        {
            return await _context.Profesor
                .Include(prof => prof.Persona)
                    .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                .Where(prof => prof.ProfesorId == id)
                .Select(prof => new ProfesorDTO
                {
                    ProfesorId = prof.ProfesorId,
                    PersonaId = prof.PersonaId,
                    UniversidadId = prof.UniversidadId,
                    Codigo = prof.Codigo,
                    PrimerNombre = prof.Persona.PrimerNombre,
                    SegundoNombre = prof.Persona.SegundoNombre,
                    PrimerApellido = prof.Persona.PrimerApellido,
                    SegundoApellido = prof.Persona.SegundoApellido,
                    TipoIdentificacion = prof.Persona.TipoIdentificacion.Descripcion,
                    Identificacion = prof.Persona.Identificacion,
                    EsActivo = prof.EsActivo
                })
                .FirstAsync();
        }
    }
}
