using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class TipoIdentificacionRepositorio : CrudSql<TipoIdentificacion>, ITipoIdentificacionRepositorio
    {
        private readonly UniversidadContext _context;

        public TipoIdentificacionRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }
    }
}
