using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Dominio.Interface
{
    public interface IMateriaRepositorio : ICrudSql<Materia>
    {
        Task<MateriaDTO> ConsultarMateriaPorId(int id);
        Task<IEnumerable<MateriaDTO>> ConsultarMateriasPorProgramaId(int programaId);
    }
}
