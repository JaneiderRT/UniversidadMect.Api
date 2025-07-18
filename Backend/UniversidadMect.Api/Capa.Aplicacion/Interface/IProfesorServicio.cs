using UniversidadMect.Api.Capa.Aplicacion.DTOs.Profesor;

namespace UniversidadMect.Api.Capa.Aplicacion.Interface
{
    public interface IProfesorServicio
    {
        public Task<ProfesorDTO> ConsultarProfesorPorId(int id);

        public Task<IEnumerable<ProfesorDTO>> ConsultarProfesores();

        public Task<IEnumerable<ProfesorDTO>> ConsultarProfesorMateriasPorId(int id);
    }
}
