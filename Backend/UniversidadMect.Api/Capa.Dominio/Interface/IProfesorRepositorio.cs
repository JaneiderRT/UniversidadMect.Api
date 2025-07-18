using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Profesor;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Dominio.Interface
{
    public interface IProfesorRepositorio : ICrudSql<Profesor>
    {
        public Task<ProfesorDTO> ConsultarProfesorPorId(int id);

        public Task<IEnumerable<ProfesorDTO>> ConsultarProfesores();

        public Task<IEnumerable<ProfesorDTO>> ConsultarProfesorMateriasPorId(int id);
    }
}
