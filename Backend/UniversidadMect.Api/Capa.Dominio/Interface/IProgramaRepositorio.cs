using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Dominio.Interface
{
    public interface IProgramaRepositorio : ICrudSql<Programa>
    {

        public Task<IEnumerable<ProgramaDTO>> ConsultarProgramasPorUniversidad(int universidadId);
    }
}
