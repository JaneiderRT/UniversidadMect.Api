using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Dominio.Interface
{
    public interface IInscripcionRepositorio : ICrudSql<Inscripcion>
    {
        public Task<IEnumerable<InscripcionDTO>> ConsultarInscripcionesPorEstudianteId(int estudianteId);
        public Task<IEnumerable<InscripcionDTO>> ConsultarInscripciones();

    }
}
