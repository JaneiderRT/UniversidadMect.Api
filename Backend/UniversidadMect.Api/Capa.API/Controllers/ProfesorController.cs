using Microsoft.AspNetCore.Mvc;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Profesor;
using UniversidadMect.Api.Capa.Aplicacion.Interface;

namespace UniversidadMect.Api.Capa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorServicio _profesorServicio;

        public ProfesorController(IProfesorServicio profesorServicio)
        {
            _profesorServicio = profesorServicio;
        }

        [HttpGet]
        [Route("ConsultarProfesorPorId")]
        public async Task<ActionResult<ProfesorDTO>> ConsultarProfesorPorId(int id)
        {
            ProfesorDTO profesorDTO = await _profesorServicio.ConsultarProfesorPorId(id);

            if (profesorDTO == null)
            {
                return StatusCode(422, "No se encontró al profesor.");
            }
            return Ok(profesorDTO);
        }

        [HttpGet]
        [Route("ConsultarProfesorMateriasPorId")]
        public async Task<ActionResult<IEnumerable<ProfesorDTO>>> ConsultarProfesorMateriasPorId(int id)
        {
            IEnumerable<ProfesorDTO> profesorDTO = await _profesorServicio.ConsultarProfesorMateriasPorId(id);

            if (profesorDTO == null)
            {
                return StatusCode(422, "No se encontraron registros de profesores y materias.");
            }
            return Ok(profesorDTO);
        }

        [HttpGet]
        [Route("ConsultarProfesores")]
        public async Task<ActionResult<IEnumerable<ProfesorDTO>>> ConsultarProfesores()
        {
            IEnumerable<ProfesorDTO> profesorDTO = await _profesorServicio.ConsultarProfesores();

            if (profesorDTO == null)
            {
                return StatusCode(422, "No se encontraron registros de profesores.");
            }
            return Ok(profesorDTO);
        }
    }
}
