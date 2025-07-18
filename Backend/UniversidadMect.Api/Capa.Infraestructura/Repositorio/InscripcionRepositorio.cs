using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class InscripcionRepositorio : CrudSql<Inscripcion>, IInscripcionRepositorio
    {
        private readonly UniversidadContext _context;

        public InscripcionRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InscripcionDTO>> ConsultarInscripciones()
        {
            return await _context.Inscripcion
                .Include(ins => ins.Estudiante)
                    .ThenInclude(ins => ins.Persona)
                .Include(ins => ins.Materia)
                .Select(ins => new InscripcionDTO
                {
                    InscripcionId = ins.InscripcionId,
                    MateriaId = ins.MateriaId,
                    NombreMateria = ins.Materia.Nombre,
                    EstudianteId = ins.EstudianteId,
                    PrimerNombreEstudiante = ins.Estudiante.Persona.PrimerNombre,
                    SegundoNombreEstudiante = ins.Estudiante.Persona.SegundoNombre,
                    PrimerApellidoEstudiante = ins.Estudiante.Persona.PrimerApellido,
                    SegundoApellidoEstudiante = ins.Estudiante.Persona.SegundoApellido,
                    EsActivo = ins.EsActivo

                }).ToListAsync();
        }

        public async Task<IEnumerable<InscripcionDTO>> ConsultarInscripcionesPorEstudianteId(int estudianteId)
        {
            return await _context.Inscripcion
                .Include(ins => ins.Estudiante)
                    .ThenInclude(ins => ins.Persona)
                .Include(ins => ins.Materia)
                .Where(ins => ins.EstudianteId == estudianteId)
                .Select(ins => new InscripcionDTO
                {
                    InscripcionId = ins.InscripcionId,
                    MateriaId = ins.MateriaId,
                    NombreMateria = ins.Materia.Nombre,
                    EstudianteId = ins.EstudianteId,
                    PrimerNombreEstudiante = ins.Estudiante.Persona.PrimerNombre,
                    SegundoNombreEstudiante = ins.Estudiante.Persona.SegundoNombre,
                    PrimerApellidoEstudiante = ins.Estudiante.Persona.PrimerApellido,
                    SegundoApellidoEstudiante = ins.Estudiante.Persona.SegundoApellido,
                    ProfesorId = ins.Materia.ProfesorId,
                    EsActivo = ins.EsActivo

                }).ToListAsync();
        }
    }
}
