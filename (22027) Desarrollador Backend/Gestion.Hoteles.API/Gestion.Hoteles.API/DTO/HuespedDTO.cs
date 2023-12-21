namespace Gestion.Hoteles.API.DTO
{
    public class HuespedDTO
    {
        public int Identificador { get; set; }
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
