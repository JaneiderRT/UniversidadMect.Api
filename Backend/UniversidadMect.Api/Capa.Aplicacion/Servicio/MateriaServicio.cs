using Capa.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;

namespace UniversidadMect.Api.Capa.Aplicacion.Servicio
{
    public class MateriaServicio : IMateriaServicio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public MateriaServicio(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IEnumerable<Materia> ConsultarMaterias()
        {
            return _unidadTrabajo.iMateriaRepositorio.GetAll();
        }

        public async Task<IEnumerable<MateriaDTO>> ConsultarMateriasPorProgramaId(int programaId)
        {
            if (programaId <= 0)
            {
                throw new ValidationException("El id del programa no puede ser menor o igual a cero.");
            }
            Programa programa = await _unidadTrabajo.iProgramaRepositorio.GetById(programaId);

            if (programa == null)
            {
                throw new ValidationException("No existe el programa.");
            }

            IEnumerable<MateriaDTO> materiaDTOs = await _unidadTrabajo.iMateriaRepositorio.ConsultarMateriasPorProgramaId(programaId);
            if (!materiaDTOs.Any())
            {
                throw new ValidationException("No existen materias para este programa.");
            }

            return materiaDTOs;

        }
    }
}
