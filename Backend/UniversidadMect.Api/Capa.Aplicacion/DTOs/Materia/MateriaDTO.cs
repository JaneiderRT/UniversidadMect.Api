namespace UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia
{
    public class MateriaDTO
    {
        public int MateriaId { get; set; }

        public string Nombre { get; set; } = null!;

        public int CreditosMateria { get; set; }

        public int ProfesorId { get; set; }

        public bool EsActivo { get; set; }

        public string NombrePrograma { get; set; } = null!;
    }
}
