using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class EstudianteRepositorio : CrudSql<Estudiante>, IEstudianteRepositorio
    {
        private readonly UniversidadContext _context;

        public EstudianteRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<EstudianteDTO>> ConsultarEstudianteInscripcionPorId(int id)
        {
            return await _context.Estudiante
                .Include(per => per.Persona)
                    .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                .Join(_context.Inscripcion,
                    es => es.EstudianteId,
                    ins => ins.EstudianteId,
                    (es, ins) => new
                    {
                        Estudiantes = es,
                        Inscripciones = ins
                    }
                )
                .Join(_context.Materia,
                    es => es.Inscripciones.MateriaId,
                    mat => mat.MateriaId,
                    (es, mat) => new
                    {
                        Materias = mat,
                        Estudiantes = es.Estudiantes,
                        Inscripciones = es.Inscripciones
                    }
                )
                .Join(_context.Profesor,
                    es => es.Materias.ProfesorId,
                    prof => prof.ProfesorId,
                    (es, prof) => new
                    {
                        Profesores = prof,
                        Materias = es.Materias,
                        Estudiantes = es.Estudiantes,
                        Inscripciones = es.Inscripciones
                    }
                )
                .Join(_context.Persona,
                    es => es.Profesores.PersonaId,
                    per => per.PersonaId,
                    (es, per) => new
                    {
                        PersonaProfesor = per,
                        Profesores = es.Profesores,
                        Materias = es.Materias,
                        Estudiantes = es.Estudiantes,
                        Inscripciones = es.Inscripciones
                    }

                )
                .Where(es => es.Estudiantes.EstudianteId == id)
                .Select(es => new EstudianteDTO
                {
                    EstudianteId = es.Estudiantes.EstudianteId,
                    PersonaId = es.Estudiantes.PersonaId,
                    UniversidadId = es.Estudiantes.UniversidadId,
                    Codigo = es.Estudiantes.Codigo,
                    CreditosEstudiante = es.Estudiantes.CreditosEstudiante,
                    PrimerNombre = es.Estudiantes.Persona.PrimerNombre,
                    SegundoNombre = es.Estudiantes.Persona.SegundoNombre,
                    PrimerApellido = es.Estudiantes.Persona.PrimerApellido,
                    SegundoApellido = es.Estudiantes.Persona.SegundoApellido,
                    TipoIdentificacion = es.Estudiantes.Persona.TipoIdentificacion.Descripcion,
                    Identificacion = es.Estudiantes.Persona.Identificacion,
                    EsActivo = es.Estudiantes.EsActivo,
                    NombreMateria = es.Materias.Nombre,
                    CreditosMateria         = es.Materias.CreditosMateria,
                    PrimerNombreProfesor    = es.PersonaProfesor.PrimerNombre,
                    SegundoNombreProfesor   = es.PersonaProfesor.SegundoNombre,
                    PrimerApellidoProfesor  = es.PersonaProfesor.PrimerApellido,
                    SegundoApellidoProfesor = es.PersonaProfesor.SegundoApellido
                })
                .ToListAsync();
        }

        public async Task<EstudianteDTO> ConsultarEstudiantePorId(int id)
        {

            return await _context.Estudiante
                .Include(per => per.Persona)
                    .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                .Where(es => es.EstudianteId == id)
                .Select(es => new EstudianteDTO
                {
                    EstudianteId = es.EstudianteId,
                    PersonaId = es.PersonaId,
                    UniversidadId = es.UniversidadId,
                    Codigo = es.Codigo,
                    CreditosEstudiante = es.CreditosEstudiante,
                    PrimerNombre = es.Persona.PrimerNombre,
                    SegundoNombre = es.Persona.SegundoNombre,
                    PrimerApellido = es.Persona.PrimerApellido,
                    SegundoApellido = es.Persona.SegundoApellido,
                    TipoIdentificacion = es.Persona.TipoIdentificacion.Descripcion,
                    Identificacion = es.Persona.Identificacion,
                    EsActivo = es.EsActivo
                })
                .FirstAsync();
        }

        public async Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantes()
        {
            return await _context.Estudiante
                .Include(per => per.Persona)
                    .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                .Select(es => new EstudianteDTO
                {
                    EstudianteId = es.EstudianteId,
                    PersonaId = es.PersonaId,
                    UniversidadId = es.UniversidadId,
                    Codigo = es.Codigo,
                    CreditosEstudiante = es.CreditosEstudiante,
                    PrimerNombre = es.Persona.PrimerNombre,
                    SegundoNombre = es.Persona.SegundoNombre,
                    PrimerApellido = es.Persona.PrimerApellido,
                    SegundoApellido = es.Persona.SegundoApellido,
                    TipoIdentificacion = es.Persona.TipoIdentificacion.Descripcion,
                    Identificacion = es.Persona.Identificacion,
                    EsActivo = es.EsActivo
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantesInscripcion()
        {
            return await _context.Estudiante
                 .Include(per => per.Persona)
                     .ThenInclude(tdoc => tdoc.TipoIdentificacion)
                 .Join(_context.Inscripcion,
                     es => es.EstudianteId,
                     ins => ins.EstudianteId,
                     (es, ins) => new
                     {
                         Estudiantes = es,
                         Inscripciones = ins
                     }
                 )
                 .Join(_context.Materia,
                     es => es.Inscripciones.MateriaId,
                     mat => mat.MateriaId,
                     (es, mat) => new
                     {
                         Materias = mat,
                         Estudiantes = es.Estudiantes,
                         Inscripciones = es.Inscripciones
                     }
                 )
                 .Join(_context.Profesor,
                     es => es.Materias.ProfesorId,
                     prof => prof.ProfesorId,
                     (es, prof) => new
                     {
                         Profesores = prof,
                         Materias = es.Materias,
                         Estudiantes = es.Estudiantes,
                         Inscripciones = es.Inscripciones
                     }
                 )
                 .Join(_context.Persona,
                     es => es.Profesores.PersonaId,
                     per => per.PersonaId,
                     (es, per) => new
                     {
                         PersonaProfesor = per,
                         Profesores = es.Profesores,
                         Materias = es.Materias,
                         Estudiantes = es.Estudiantes,
                         Inscripciones = es.Inscripciones
                     }

                 )
                 .Select(es => new EstudianteDTO
                 {
                     EstudianteId = es.Estudiantes.EstudianteId,
                     PersonaId = es.Estudiantes.PersonaId,
                     UniversidadId = es.Estudiantes.UniversidadId,
                     Codigo = es.Estudiantes.Codigo,
                     CreditosEstudiante = es.Estudiantes.CreditosEstudiante,
                     PrimerNombre = es.Estudiantes.Persona.PrimerNombre,
                     SegundoNombre = es.Estudiantes.Persona.SegundoNombre,
                     PrimerApellido = es.Estudiantes.Persona.PrimerApellido,
                     SegundoApellido = es.Estudiantes.Persona.SegundoApellido,
                     TipoIdentificacion = es.Estudiantes.Persona.TipoIdentificacion.Descripcion,
                     Identificacion = es.Estudiantes.Persona.Identificacion,
                     EsActivo = es.Estudiantes.EsActivo,
                     NombreMateria = es.Materias.Nombre,
                     CreditosMateria = es.Materias.CreditosMateria,
                     PrimerNombreProfesor = es.PersonaProfesor.PrimerNombre,
                     SegundoNombreProfesor = es.PersonaProfesor.SegundoNombre,
                     PrimerApellidoProfesor = es.PersonaProfesor.PrimerApellido,
                     SegundoApellidoProfesor = es.PersonaProfesor.SegundoApellido
                 })
                 .ToListAsync();
        }
    }
}
