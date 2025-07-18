namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Profesor
{
    public class ProfesorDTO
    {
        public int ProfesorId { get; set; }

        public int PersonaId { get; set; }

        public int UniversidadId { get; set; }

        public string Codigo { get; set; } = null!;

        public bool EsActivo { get; set; }

        public string PrimerNombre { get; set; } = null!;

        public string? SegundoNombre { get; set; }

        public string PrimerApellido { get; set; } = null!;

        public string? SegundoApellido { get; set; }

        public string? Identificacion { get; set; }

        public string TipoIdentificacion { get; set; } = null!;

        public string NombreMateria { get; set; } = null!;
    }
}
