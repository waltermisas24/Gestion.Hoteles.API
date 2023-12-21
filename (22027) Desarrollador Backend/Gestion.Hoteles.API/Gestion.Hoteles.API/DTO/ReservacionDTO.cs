namespace Gestion.Hoteles.API.DTO
{
    public class ReservacionDTO
    {
        public int Identificador { get; set; }
        public int IdentificadorHabitacion { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFinal { get; set; }
        public double Precio { get; set; }
        public string NombreContactoEmergencia { get; set; }
        public string TelefonoContactoEmergencia { get; set; }
        public bool Estado { get; set; }
        public List<HuespedDTO> Huespedes { get; set; }
    }
}
