using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;
using UniversidadMect.Api.Capa.Infraestructura.Datos;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio.UnidadTrabajo
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly UniversidadContext _context;

        private readonly IEstudianteRepositorio _estudianteRepositorio;

        private readonly IInscripcionRepositorio _inscripcionRepositorio;

        private readonly IMateriaRepositorio _materiaRepositorio;

        private readonly IPersonaRepositorio _personaRepositorio;

        private readonly IProfesorRepositorio _profesorRepositorio;

        private readonly IProgramaMateriaRepositorio _programaMateriaRepositorio;

        private readonly IProgramaRepositorio _programaRepositorio;

        private readonly ITipoIdentificacionRepositorio _tipoIdentificacionRepositorio;

        private readonly IUniversidadRepositorio _universidadRepositorio;

        public UnidadTrabajo(UniversidadContext context)
        {
            _context = context;
        }

        public IEstudianteRepositorio iEstudianteRepositorio => _estudianteRepositorio ?? new EstudianteRepositorio(_context);

        public IInscripcionRepositorio iInscripcionRepositorio => _inscripcionRepositorio ?? new InscripcionRepositorio(_context);

        public IMateriaRepositorio iMateriaRepositorio => _materiaRepositorio ?? new MateriaRepositorio(_context);

        public IPersonaRepositorio iPersonaRepositorio => _personaRepositorio ?? new PersonaRepositorio(_context);

        public IProfesorRepositorio iProfesorRepositorio => _profesorRepositorio ?? new ProfesorRepositorio(_context);

        public IProgramaMateriaRepositorio iProgramaMateriaRepositorio => _programaMateriaRepositorio ?? new ProgramaMateriaRepositorio(_context);

        public IProgramaRepositorio iProgramaRepositorio => _programaRepositorio ?? new ProgramaRepositorio(_context);

        public ITipoIdentificacionRepositorio iTipoIdentificacionRepositorio => _tipoIdentificacionRepositorio ?? new TipoIdentificacionRepositorio(_context);

        public IUniversidadRepositorio iUniversidadRepositorio => _universidadRepositorio ?? new UniversidadRepositorio(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
