namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Universidad
{
    public class UniversidadDTO
    {
        public int UniversidadId { get; set; }

        public string Nombre { get; set; } = null!;

        public int Nit { get; set; }

        public int CodigoVerificacion { get; set; }

        public string Direccion { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public bool EsActivo { get; set; }
    }
}
