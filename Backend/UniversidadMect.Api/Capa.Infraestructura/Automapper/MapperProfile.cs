using AutoMapper;
using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Universidad;

namespace UniversidadMect.Api.Capa.Infraestructura.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<Estudiante, EstudianteDTO>().ReverseMap();

            CreateMap<Universidad, UniversidadDTO>().ReverseMap();

            CreateMap<Programa, ProgramaDTO>().ReverseMap();

            CreateMap<Materia, MateriaDTO>().ReverseMap();

            CreateMap<Inscripcion, InscripcionDTO>().ReverseMap();

            CreateMap<Inscripcion, InsertarInscripcionDTO>().ReverseMap();
        }
    }
}
