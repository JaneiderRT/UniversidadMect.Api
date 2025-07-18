using Capa.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Universidad;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Aplicacion.Utilidades;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;

namespace UniversidadMect.Api.Capa.Aplicacion.Servicio
{
    public class UniversidadServicio : IUniversidadServicio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public UniversidadServicio(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public async Task<Universidad> ConsultarUniversidadPorId(int id)
        {
            if (id <= 0)
            {
                throw new ExcepcionGenerica("El id del universidad no puede ser menor o igual a cero.");
            }

            Universidad universidad = await _unidadTrabajo.iUniversidadRepositorio.GetById(id);

            if (universidad == null)
            {
                throw new ValidationException("El id del estudiante no existe.");
            }

            return universidad;
        }
    }
}
