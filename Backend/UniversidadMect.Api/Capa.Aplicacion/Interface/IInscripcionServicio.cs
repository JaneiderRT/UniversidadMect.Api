using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion;

namespace UniversidadMect.Api.Capa.Aplicacion.Interface
{
    public interface IInscripcionServicio
    {
        public Task<IEnumerable<InscripcionDTO>> ConsultarInscripcionesPorEstudianteId(int estudianteId);
        public Task<IEnumerable<InscripcionDTO>> ConsultarInscripciones();
        public Task<Inscripcion> InsertarInscripcion(Inscripcion inscripcion);
        public Task<Inscripcion> ActualizarInscripcion(ActualizarInscripcionDTO inscripcion);
        public Task<bool> InactivarInscripcion(int inscripcionId);
    }
}
