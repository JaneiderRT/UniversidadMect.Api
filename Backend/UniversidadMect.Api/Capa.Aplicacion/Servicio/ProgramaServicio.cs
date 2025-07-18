using Capa.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;

namespace UniversidadMect.Api.Capa.Aplicacion.Servicio
{
    public class ProgramaServicio : IProgramaServicio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public ProgramaServicio(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IEnumerable<Programa> ConsultarProgramas()
        {
            return _unidadTrabajo.iProgramaRepositorio.GetAll();
        }

        public async Task<IEnumerable<ProgramaDTO>> ConsultarProgramasPorUniversidad(int universidadId)
        {
            if (universidadId <= 0)
            {
                throw new ValidationException("El id de la universidad no puede ser menor o igual a cero.");
            }

            Universidad universidad = await _unidadTrabajo.iUniversidadRepositorio.GetById(universidadId);

            if (universidad == null)
            {
                throw new ValidationException("No existe la universidad.");
            }

            IEnumerable<ProgramaDTO> programaDTOs = await _unidadTrabajo.iProgramaRepositorio.ConsultarProgramasPorUniversidad(universidadId);

            if (!programaDTOs.Any())
            {
                throw new ValidationException("No existen programas relacionados a la universidad.");
            }

            return programaDTOs;
        }
    }
}
