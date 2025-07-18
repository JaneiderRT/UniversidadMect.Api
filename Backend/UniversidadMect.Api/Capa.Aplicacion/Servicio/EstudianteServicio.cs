using AutoMapper;
using Capa.Dominio.Entidades;
using System.ComponentModel.DataAnnotations;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Aplicacion.Interface;
using UniversidadMect.Api.Capa.Aplicacion.Utilidades;
using UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo;
using UniversidadMect.Api.Capa.Infraestructura.Automapper;

namespace UniversidadMect.Api.Capa.Aplicacion.Servicio
{
    public class EstudianteServicio : IEstudianteServicio
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public EstudianteServicio(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public async Task<Estudiante> ActualizarEstudiante(ActualizarEstudianteDTO estudiante)
        {
            Estudiante estudianteBD = await _unidadTrabajo.iEstudianteRepositorio.GetById(estudiante.EstudianteId);

            if (estudianteBD == null)
            {
                throw new ValidationException("El id del estudiante no existe.");
            }

            estudianteBD.EstudianteId = estudiante.EstudianteId;
            estudianteBD.PersonaId = estudiante.PersonaId;
            estudianteBD.UniversidadId = estudiante.UniversidadId;
            estudianteBD.Codigo = estudiante.Codigo;
            estudianteBD.CreditosEstudiante = estudiante.CreditosEstudiante;
            estudianteBD.EsActivo = estudiante.EsActivo;

            _unidadTrabajo.iEstudianteRepositorio.Update(estudianteBD);
            await _unidadTrabajo.SaveChangesAsync();
            return estudianteBD;
        }

        public async Task<IEnumerable<EstudianteDTO>> ConsultarEstudianteInscripcionPorId(int id)
        {
            if (id <= 0)
            {
                throw new ValidationException("El id del estudiante no puede ser menor o igual a cero.");
            }
            Estudiante estudiante = await _unidadTrabajo.iEstudianteRepositorio.GetById(id);

            if (estudiante == null)
            {
                throw new ValidationException("El id del estudiante no existe.");
            }

            return await _unidadTrabajo.iEstudianteRepositorio.ConsultarEstudianteInscripcionPorId(id);
        }

        public async Task<EstudianteDTO> ConsultarEstudiantePorId(int id)
        {
            if (id <= 0)
            {
                throw new ExcepcionGenerica("El id del estudiante no puede ser menor o igual a cero.");
            }

            Estudiante estudiante = await _unidadTrabajo.iEstudianteRepositorio.GetById(id);

            if (estudiante == null)
            {
                throw new ValidationException("El id del estudiante no existe.");
            }

            return await _unidadTrabajo.iEstudianteRepositorio.ConsultarEstudiantePorId(id);
        }

        public async Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantes()
        {
            return await _unidadTrabajo.iEstudianteRepositorio.ConsultarEstudiantes();
        }

        public async Task<IEnumerable<EstudianteDTO>> ConsultarEstudiantesInscripcion()
        {
            return await _unidadTrabajo.iEstudianteRepositorio.ConsultarEstudiantesInscripcion();
        }
    }
}
