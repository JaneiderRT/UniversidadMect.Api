namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Inscripcion
{
    public class InsertarInscripcionDTO
    {
        public int MateriaId { get; set; }

        public int EstudianteId { get; set; }

        public bool EsActivo { get; set; }
    }
}
