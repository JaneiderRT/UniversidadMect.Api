namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante
{
    public class EstudianteDTO
    {
        public int EstudianteId { get; set; }

        public int PersonaId { get; set; }

        public int UniversidadId { get; set; }

        public string Codigo { get; set; } = null!;

        public int CreditosEstudiante { get; set; }

        public string PrimerNombre { get; set; } = null!;

        public string? SegundoNombre { get; set; }

        public string PrimerApellido { get; set; } = null!;

        public string? SegundoApellido { get; set; }

        public string TipoIdentificacion { get; set; } = null!;

        public string? Identificacion { get; set; }

        public bool EsActivo { get; set; }

        public string NombreMateria { get; set; } = null!;

        public int CreditosMateria { get; set; }

        public string PrimerNombreProfesor { get; set; } = null!;

        public string? SegundoNombreProfesor { get; set; }

        public string PrimerApellidoProfesor { get; set; } = null!;

        public string? SegundoApellidoProfesor { get; set; }
    }
}
