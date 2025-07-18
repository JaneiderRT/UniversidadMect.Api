using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class ProgramaMateriaRepositorio : CrudSql<ProgramaMateria>, IProgramaMateriaRepositorio
    {
        private readonly UniversidadContext _context;

        public ProgramaMateriaRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }
    }
}
