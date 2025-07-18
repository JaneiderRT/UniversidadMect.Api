using System.ComponentModel.DataAnnotations;

namespace UniversidadMect.Api.Capa.Aplicacion.Utilidades
{
    public class ExcepcionGenerica : ValidationException
    {
        public ExcepcionGenerica(string mensaje) : base(mensaje) { }
    }
}
