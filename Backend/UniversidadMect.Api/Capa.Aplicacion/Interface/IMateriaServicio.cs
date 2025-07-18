using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;

namespace UniversidadMect.Api.Capa.Aplicacion.Interface
{
    public interface IMateriaServicio
    {
        public IEnumerable<Materia> ConsultarMaterias();
        public Task<IEnumerable<MateriaDTO>> ConsultarMateriasPorProgramaId(int programaId);
    }
}
