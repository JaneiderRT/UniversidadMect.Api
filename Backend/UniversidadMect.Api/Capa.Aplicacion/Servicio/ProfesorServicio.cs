using Capa.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Profesor;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;

namespace UniversidadMect.Api.Capa.Aplicacion.Servicio
{
    public class ProfesorServicio : IProfesorServicio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public ProfesorServicio(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public Task<IEnumerable<ProfesorDTO>> ConsultarProfesores()
        {
            return _unidadTrabajo.iProfesorRepositorio.ConsultarProfesores();
        }

        public async Task<IEnumerable<ProfesorDTO>> ConsultarProfesorMateriasPorId(int id)
        {
            if (id <= 0)
            {
                throw new ValidationException("El id del profesor no puede ser menor o igual a cero.");
            }

            Profesor profesor = await _unidadTrabajo.iProfesorRepositorio.GetById(id);

            if (profesor == null)
            {
                throw new ValidationException("El id del profesor no existe.");
            }

            return await _unidadTrabajo.iProfesorRepositorio.ConsultarProfesorMateriasPorId(id);
        }

        public async Task<ProfesorDTO> ConsultarProfesorPorId(int id)
        {
            if (id <= 0)
            {
                throw new ValidationException("El id del profesor no puede ser menor o igual a cero.");
            }

            Profesor profesor = await _unidadTrabajo.iProfesorRepositorio.GetById(id);

            if (profesor == null)
            {
                throw new ValidationException("El id del profesor no existe.");
            }

            return await _unidadTrabajo.iProfesorRepositorio.ConsultarProfesorPorId(id);
        }
    }
}
