using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Dominio.Interface
{
    public interface IEstudianteRepositorio : ICrudSql<Estudiante>
    {
        public Task<EstudianteDTO> ConsultarEstudiantePorId(int id);

        public Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantes();

        public Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantesInscripcion();

        public Task<IEnumerable<EstudianteDTO>> ConsultarEstudianteInscripcionPorId(int id);
    }
}
