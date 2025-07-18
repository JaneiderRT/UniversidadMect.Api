using AutoMapper;
using Capa.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;
using UniversidadMect.Api.Capa.Aplicacion.Interface;

namespace UniversidadMect.Api.Capa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramaController : ControllerBase
    {
        private readonly IProgramaServicio _programaServicio;
        private readonly IMapper _imapper;

        public ProgramaController(IProgramaServicio programaServicio, IMapper mapper)
        {
            _programaServicio = programaServicio;
            _imapper = mapper;
        }

        [HttpGet]
        [Route("ConsultarProgramas")]
        public ActionResult<IEnumerable<ProgramaDTO>> ConsultarProgramas()
        {
            IEnumerable<Programa> programa = _programaServicio.ConsultarProgramas();

            return Ok(_imapper.Map<IEnumerable<ProgramaDTO>>(programa));
        }

        [HttpGet]
        [Route("ConsultarProgramasPorUniversidad")]
        public async Task<ActionResult<IEnumerable<ProgramaDTO>>> ConsultarProgramasPorUniversidad(int universidadId)
        {
            IEnumerable<ProgramaDTO> programaDTOs = await _programaServicio.ConsultarProgramasPorUniversidad(universidadId);

            return Ok(programaDTOs);
        }
    }
}
