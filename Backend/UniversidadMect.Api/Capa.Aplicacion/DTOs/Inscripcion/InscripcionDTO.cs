namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion
{
    public class InscripcionDTO
    {
        public int InscripcionId { get; set; }

        public int MateriaId { get; set; }

        public string NombreMateria { get; set; } = null!;

        public int EstudianteId { get; set; }

        public string PrimerNombreEstudiante { get; set; } = null!;

        public string? SegundoNombreEstudiante { get; set; }

        public string PrimerApellidoEstudiante { get; set; } = null!;

        public string? SegundoApellidoEstudiante { get; set; }

        public int ProfesorId { get; set; }

        public bool EsActivo { get; set; }
    }
}
