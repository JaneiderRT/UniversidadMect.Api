using AutoMapper;
using Capa.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion;
using UniversidadMect.Api.Capa.Aplicacion.Interface;

namespace UniversidadMect.Api.Capa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InscripcionController : ControllerBase
    {
        private readonly IInscripcionServicio _inscripcionServicio;
        private readonly IMapper _imapper;

        public InscripcionController(IInscripcionServicio inscripcionServicio, IMapper mapper)
        {
            _inscripcionServicio = inscripcionServicio;
            _imapper = mapper;
        }

        [HttpGet]
        [Route("ConsultarInscripciones")]
        public async Task<ActionResult<IEnumerable<InscripcionDTO>>> ConsultarInscripciones()
        {
            IEnumerable<InscripcionDTO> inscripciones = await _inscripcionServicio.ConsultarInscripciones();
            return Ok(inscripciones);
        }
        [HttpGet]
        [Route("ConsultarInscripcionesPorEstudianteId")]
        public async Task<ActionResult<IEnumerable<InscripcionDTO>>> ConsultarInscripcionesPorEstudianteId(int estudianteId)
        {
            IEnumerable<InscripcionDTO> inscripciones = await _inscripcionServicio.ConsultarInscripcionesPorEstudianteId(estudianteId);
            return Ok(inscripciones);
        }
        [HttpPut]
        [Route("ActualizarInscripcion")]
        public async Task<ActionResult<InscripcionDTO>> ActualizarInscripcion([FromBody] ActualizarInscripcionDTO inscripcion)
        {
            if (inscripcion == null || inscripcion.InscripcionId <= 0)
            {
                return BadRequest("Datos de inscripción inválidos.");
            }
            Inscripcion updatedInscripcion = await _inscripcionServicio.ActualizarInscripcion(inscripcion);
            return Ok(_imapper.Map<InscripcionDTO>(updatedInscripcion));
        }

        [HttpPut]
        [Route("InactivarInscripcion")]
        public async Task<ActionResult<bool>> InactivarInscripcion(int inscripcionId)
        {
            if (inscripcionId <= 0)
            {
                return BadRequest("El id de la inscripción no puede ser menor o igual a cero.");
            }
            bool result = await _inscripcionServicio.InactivarInscripcion(inscripcionId);
            if (result)
            {
                return Ok(true);
            }
            return NotFound("Inscripción no encontrada o ya inactiva.");
        }

        [HttpPost]
        [Route("InsertarInscripcion")]
        public async Task<ActionResult<InscripcionDTO>> InsertarInscripcion([FromBody] InsertarInscripcionDTO inscripcionDTO)
        {
            if (inscripcionDTO == null)
            {
                return BadRequest("Datos de inscripción inválidos.");
            }
            Inscripcion inscripcion = _imapper.Map<Inscripcion>(inscripcionDTO);
            Inscripcion nuevaInscripcion = await _inscripcionServicio.InsertarInscripcion(inscripcion);
            return CreatedAtAction(nameof(ConsultarInscripciones), new { id = nuevaInscripcion.InscripcionId }, _imapper.Map<InscripcionDTO>(nuevaInscripcion));
        }
    }
}
