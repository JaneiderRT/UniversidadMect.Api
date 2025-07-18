namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion
{
    public class ActualizarInscripcionDTO
    {
        public int InscripcionId { get; set; }
        public int MateriaId { get; set; }

        public int EstudianteId { get; set; }

        public bool EsActivo { get; set; }
    }
}
