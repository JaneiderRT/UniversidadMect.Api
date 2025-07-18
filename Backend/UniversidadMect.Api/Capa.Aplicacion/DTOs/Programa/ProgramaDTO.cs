namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa
{
    public class ProgramaDTO
    {
        public int ProgramaId { get; set; }

        public int UniversidadId { get; set; }

        public string Nombre { get; set; } = null!;

        public int CreditosTotales { get; set; }

        public bool EsActivo { get; set; }
    }
}
