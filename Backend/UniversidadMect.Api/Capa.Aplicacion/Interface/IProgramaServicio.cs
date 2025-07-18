using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;

namespace UniversidadMect.Api.Capa.Aplicacion.Interface
{
    public interface IProgramaServicio
    {
        public IEnumerable<Programa> ConsultarProgramas();

        public Task<IEnumerable<ProgramaDTO>> ConsultarProgramasPorUniversidad(int universidadId);
    }
}
