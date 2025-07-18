using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;

namespace UniversidadMect.Api.Capa.Aplicacion.Interface
{
    public interface IEstudianteServicio
    {
        public Task<EstudianteDTO> ConsultarEstudiantePorId(int id);

        public Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantes();

        public Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantesInscripcion();

        public Task<IEnumerable<EstudianteDTO>> ConsultarEstudianteInscripcionPorId(int id);

        public Task<Estudiante> ActualizarEstudiante(ActualizarEstudianteDTO estudiante);
    }
}
