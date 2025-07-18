using AutoMapper;
using Capa.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Aplicacion.Interface;

namespace UniversidadMect.Api.Capa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteServicio _estudianteServicio;
        private readonly IMapper _iMapper;

        public EstudianteController(IEstudianteServicio estudianteServicio, IMapper mapper)
        {
            _estudianteServicio = estudianteServicio;
            _iMapper = mapper;
        }

        [HttpGet]
        [Route("ConsultarEstudianteInscripcionPorId")]
        public async Task<ActionResult<IEnumerable<EstudianteDTO>>> ConsultarEstudianteInscripcionPorId(int id)
        {
            IEnumerable<EstudianteDTO> estudianteDTO = await _estudianteServicio.ConsultarEstudianteInscripcionPorId(id);

            if(estudianteDTO == null)
            {
                return StatusCode(422, "No se encontró la información de la inscripción del estudiante.");
            }
            return Ok(estudianteDTO);
        }

        [HttpGet]
        [Route("ConsultarEstudiantePorId")]
        public async Task<ActionResult<EstudianteDTO>> ConsultarEstudiantePorId(int id)
        {
            EstudianteDTO estudianteDTO = await _estudianteServicio.ConsultarEstudiantePorId(id);

            if (estudianteDTO == null)
            {
                return StatusCode(422, "No se encontró el estudiante.");
            }
            return Ok(estudianteDTO);
        }

        [HttpGet]
        [Route("ConsultarEstudiantes")]
        public async Task<ActionResult<IEnumerable<EstudianteDTO>>> ConsultarEstudiantes()
        {
            IEnumerable<EstudianteDTO> estudianteDTO = await _estudianteServicio.ConsultarEstudiantes();

            if (estudianteDTO == null)
            {
                return StatusCode(422, "No se encontraron registros de estudiantes.");
            }
            return Ok(estudianteDTO);
        }

        [HttpGet]
        [Route("ConsultarEstudiantesInscripcion")]
        public async Task<ActionResult<IEnumerable<EstudianteDTO>>> ConsultarEstudiantesInscripcion()
        {
            IEnumerable<EstudianteDTO> estudianteDTO = await _estudianteServicio.ConsultarEstudiantesInscripcion();

            if (estudianteDTO == null)
            {
                return StatusCode(422, "No se encontraron registros de inscripcion y estudiantes.");
            }
            return Ok(estudianteDTO);
        }

        [HttpPut]
        [Route("ActualizarEstudiante")]
        public async Task<ActionResult<EstudianteDTO>> ActualizarEstudiante([FromBody] ActualizarEstudianteDTO paramEstudiante)
        {
            Estudiante estudiante = await _estudianteServicio.ActualizarEstudiante(paramEstudiante);
            return Ok(_iMapper.Map<EstudianteDTO>(estudiante));
        }
    }
}
