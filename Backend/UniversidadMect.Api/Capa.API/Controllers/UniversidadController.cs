using AutoMapper;
using Capa.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Universidad;
using UniversidadMect.Api.Capa.Aplicacion.Interface;

namespace UniversidadMect.Api.Capa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversidadController : ControllerBase
    {
        private readonly IUniversidadServicio _universidadServicio;
        private readonly IMapper _iMapper;

        public UniversidadController(IUniversidadServicio universidadServicio, IMapper mapper)
        {
            _universidadServicio = universidadServicio;
            _iMapper = mapper;
        }

        [HttpGet]
        [Route("ConsultarUniversidadPorId")]
        public async Task<ActionResult<UniversidadDTO>> ConsultarUniversidadPorId(int id)
        {
            Universidad universidad = await _universidadServicio.ConsultarUniversidadPorId(id);

            if (universidad == null)
            {
                return StatusCode(422, "No se encontró el universidad.");
            }
            return Ok(_iMapper.Map<UniversidadDTO>(universidad));
        }
    }
}
