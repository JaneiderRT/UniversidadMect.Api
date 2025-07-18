namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Estudiante
{
    public class ActualizarEstudianteDTO
    {
        public int EstudianteId { get; set; }

        public int PersonaId { get; set; }

        public int UniversidadId { get; set; }

        public string Codigo { get; set; } = null!;

        public int CreditosEstudiante { get; set; }

        public bool EsActivo { get; set; }
    }
}
