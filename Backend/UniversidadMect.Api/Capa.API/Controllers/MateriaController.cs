using AutoMapper;
using Capa.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Aplicacion.Interface;

namespace UniversidadMect.Api.Capa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaServicio _materiaServicio;
        private readonly IMapper _imapper;

        public MateriaController(IMateriaServicio materiaServicio, IMapper mapper)
        {
            _materiaServicio = materiaServicio;
            _imapper = mapper;
        }

        [HttpGet]
        [Route("ConsultarMaterias")]
        public ActionResult<IEnumerable<MateriaDTO>> ConsultarMaterias()
        {
            IEnumerable<Materia> materias = _materiaServicio.ConsultarMaterias();
            return Ok(_imapper.Map<IEnumerable<MateriaDTO>>(materias));
        }

        [HttpGet]
        [Route("ConsultarMateriasPorProgramaId")]
        public async Task<ActionResult<IEnumerable<MateriaDTO>>> ConsultarMateriasPorProgramaId(int programaId)
        {
            IEnumerable<MateriaDTO> materiaDTOs = await _materiaServicio.ConsultarMateriasPorProgramaId(programaId);
            return Ok(materiaDTOs);
        }
    }
}
